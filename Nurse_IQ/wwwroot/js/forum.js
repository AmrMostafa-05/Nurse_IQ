document.addEventListener("DOMContentLoaded", function () {
    // Initialize all functions
    initFilters();
    initSorting();
    initSearch();
    initCreatePostModal();
});

function initFilters() {
    const filterTags = document.querySelectorAll('.filter-tag');
    const topicsList = document.querySelector('.topics-list');

    filterTags.forEach(tag => {
        tag.addEventListener('click', function () {
            // Remove active class from all
            filterTags.forEach(t => t.classList.remove('active'));
            this.classList.add('active');

            const filterValue = this.getAttribute('data-filter');
            const sortValue = document.getElementById('sortTopics')?.value || "latest";

            // Call backend
            fetch(`/Forum/GetByCategory?category=${filterValue}&sort=${sortValue}`)
                .then(response => response.text())
                .then(html => {
                    topicsList.innerHTML = html;
                })
                .catch(err => console.error(err));
        });
    });
}

function initSorting() {
    const sortSelect = document.getElementById('sortTopics');
    const topicsList = document.querySelector('.topics-list');

    if (sortSelect) {
        sortSelect.addEventListener('change', function () {
            const sortValue = this.value;
            const activeFilter = document.querySelector('.filter-tag.active');
            const filterValue = activeFilter?.getAttribute('data-filter') || "all";

            fetch(`/Forum/GetByCategory?category=${filterValue}&sort=${sortValue}`)
                .then(response => response.text())
                .then(html => {
                    topicsList.innerHTML = html;
                    showToast(`تم ترتيب المواضيع حسب: ${this.options[this.selectedIndex].text}`, 'info');
                })
                .catch(err => console.error(err));
        });
    }
}

function initSearch() {
    const searchInput = document.getElementById('searchForum');
    const searchBtn = document.querySelector('.btn-outline-primary');
    const topicsList = document.querySelector('.topics-list');

    if (searchBtn && searchInput) {
        searchBtn.addEventListener('click', function () {
            const searchTerm = searchInput.value.trim();
            if (searchTerm.length > 0) {
                fetch(`/Forum/Search?search=${encodeURIComponent(searchTerm)}`)
                    .then(response => response.text())
                    .then(html => {
                        topicsList.innerHTML = html;
                        showToast(`تم عرض نتائج البحث عن: ${searchTerm}`, 'success');
                    })
                    .catch(err => console.error(err));
            } else {
                showToast('من فضلك أدخل كلمة للبحث', 'warning');
            }
        });
    }
}

function initCreatePostModal() {
    const modal = document.getElementById('createPostModal');
    const form = modal?.querySelector('form');

    if (form) {
        form.addEventListener('submit', function (e) {
            e.preventDefault();

            const formData = new FormData(this);

            fetch('/Forum/Create', {
                method: 'POST',
                body: formData
            })
                .then(response => {
                    if (response.ok) {
                        return response.text();
                    }
                    throw new Error('فشل في إنشاء الموضوع');
                })
                .then(html => {
                    const topicsList = document.querySelector('.topics-list');
                    topicsList.insertAdjacentHTML('afterbegin', html);

                    const bootstrapModal = bootstrap.Modal.getInstance(modal);
                    bootstrapModal.hide();

                    form.reset();
                    showToast('تم إنشاء الموضوع بنجاح', 'success');
                })
                .catch(error => {
                    showToast(error.message, 'error');
                });
        });
    }
}

// Toast function
function showToast(message, type = 'info') {
    const toastContainer = document.getElementById('toastContainer');
    if (!toastContainer) return;

    const toastEl = document.createElement('div');
    toastEl.className = `toast align-items-center text-bg-${type === 'error' ? 'danger' :
        type === 'success' ? 'success' :
            type === 'warning' ? 'warning' : 'primary'} border-0 mb-2`;
    toastEl.role = "alert";
    toastEl.innerHTML = `
        <div class="d-flex">
            <div class="toast-body">
                ${message}
            </div>
            <button type="button" class="btn-close btn-close-white me-2 m-auto" data-bs-dismiss="toast"></button>
        </div>
    `;

    toastContainer.appendChild(toastEl);
    const toast = new bootstrap.Toast(toastEl, { delay: 3000 });
    toast.show();

    toastEl.addEventListener('hidden.bs.toast', () => toastEl.remove());
}
