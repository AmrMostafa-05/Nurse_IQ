// Forum functionality
document.addEventListener('DOMContentLoaded', function() {
    // Initialize filters
    initFilters();
    
    // Initialize topic sorting
    initSorting();
    
    // Initialize scroll progress
    initScrollProgress();
    
    // Check authentication status
    checkAuthStatus();
});

// Initialize filters
function initFilters() {
    const filterTags = document.querySelectorAll('.filter-tag');
    const topicItems = document.querySelectorAll('.topic-item');
    
    filterTags.forEach(tag => {
        tag.addEventListener('click', function() {
            // Remove active class from all tags
            filterTags.forEach(t => t.classList.remove('active'));
            
            // Add active class to clicked tag
            this.classList.add('active');
            
            const filterValue = this.getAttribute('data-filter');
            
            // Show/hide topics based on filter
            topicItems.forEach(item => {
                if (filterValue === 'all') {
                    item.style.display = 'block';
                } else {
                    const topicCategory = item.getAttribute('data-category');
                    if (topicCategory === filterValue) {
                        item.style.display = 'block';
                    } else {
                        item.style.display = 'none';
                    }
                }
            });
        });
    });
}

// Initialize topic sorting
function initSorting() {
    const sortSelect = document.getElementById('sortTopics');
    
    if (sortSelect) {
        sortSelect.addEventListener('change', function() {
            const sortValue = this.value;
            
            // In a real application, this would make an API call
            // For now, we'll just show a toast notification
            showToast(`تم ترتيب المواضيع حسب: ${this.options[this.selectedIndex].text}`, 'info');
        });
    }
}

// Initialize scroll progress
function initScrollProgress() {
    const scrollProgress = document.getElementById('scrollProgress');
    
    if (scrollProgress) {
        window.addEventListener('scroll', function() {
            const windowHeight = window.innerHeight;
            const documentHeight = document.documentElement.scrollHeight;
            const scrollTop = window.pageYOffset || document.documentElement.scrollTop;
            const scrollPercent = (scrollTop / (documentHeight - windowHeight)) * 100;
            
            scrollProgress.style.width = scrollPercent + '%';
        });
    }
}

// Show new topic modal
function showNewTopicModal() {
    // Check if user is authenticated
    if (!isAuthenticated()) {
        showToast('يجب تسجيل الدخول لإنشاء موضوع جديد', 'warning');
        return;
    }
    
    const modal = new bootstrap.Modal(document.getElementById('newTopicModal'));
    modal.show();
}

// Create new topic
function createNewTopic() {
    const categorySelect = document.querySelector('#newTopicModal select');
    const titleInput = document.querySelector('#newTopicModal input[type="text"]');
    const contentTextarea = document.querySelector('#newTopicModal textarea');
    
    if (!titleInput.value.trim()) {
        showToast('يرجى إدخال عنوان للموضوع', 'warning');
        return;
    }
    
    if (!contentTextarea.value.trim()) {
        showToast('يرجى إدخال محتوى للموضوع', 'warning');
        return;
    }
    
    // In a real application, this would make an API call
    // For now, we'll simulate success
    showToast('تم إنشاء الموضوع بنجاح', 'success');
    
    // Reset form
    titleInput.value = '';
    contentTextarea.value = '';
    categorySelect.selectedIndex = 0;
    
    // Close modal
    const modal = bootstrap.Modal.getInstance(document.getElementById('newTopicModal'));
    modal.hide();
}

// Show category topics
function showCategoryTopics(category) {
    const categoryNames = {
        'general': 'النقاشات العامة',
        'study': 'المحتوى الدراسي',
        'practical': 'المحتوى العملي',
        'support': 'الدعم النفسي'
    };
    
    showToast(`سيتم عرض مواضيع قسم: ${categoryNames[category] || category}`, 'info');
    
    // In a real application, this would filter the topics
    const filterTag = document.querySelector(`.filter-tag[data-filter="${category}"]`);
    if (filterTag) {
        filterTag.click();
    }
}

// Show topic details
function showTopicDetails(topicId) {
    // In a real application, this would navigate to the topic details page
    showToast(`سيتم عرض تفاصيل الموضوع رقم: ${topicId}`, 'info');
    
    // Simulate navigation after a short delay
    setTimeout(() => {
        window.location.href = `/Forum/Details/${topicId}`;
    }, 1000);
}

// Show search modal
function showSearchModal() {
    const searchModal = new bootstrap.Modal(document.getElementById('searchModal'));
    searchModal.show();
}

// Perform search
function performSearch() {
    const searchInput = document.querySelector('#searchModal input[type="search"]');
    const searchTerm = searchInput.value.trim();
    
    if (!searchTerm) {
        showToast('يرجى إدخال مصطلح البحث', 'warning');
        return;
    }
    
    showToast(`جاري البحث عن: ${searchTerm}`, 'info');
    
    // Close modal
    const modal = bootstrap.Modal.getInstance(document.getElementById('searchModal'));
    modal.hide();
    
    // In a real application, this would perform the search
    // For now, we'll simulate a search result
    setTimeout(() => {
        showToast(`تم العثور على 5 نتائج لـ: ${searchTerm}`, 'success');
    }, 1500);
}

// Check authentication status
function checkAuthStatus() {
    // In a real application, this would check if the user is authenticated
    // For demo purposes, we'll assume the user is not authenticated
    const authButtons = document.querySelector('.auth-buttons');
    const userMenu = document.getElementById('user-menu');
    
    if (authButtons && userMenu) {
        authButtons.style.display = 'block';
        userMenu.style.display = 'none';
    }
}

// Check if user is authenticated
function isAuthenticated() {
    // In a real application, this would check the authentication status
    // For demo purposes, we'll return false
    return false;
}

// Show toast notification
function showToast(message, type = 'info') {
    // Create toast element
    const toast = document.createElement('div');
    toast.className = `toast align-items-center text-white bg-${type}`;
    toast.setAttribute('role', 'alert');
    toast.setAttribute('aria-live', 'assertive');
    toast.setAttribute('aria-atomic', 'true');
    
    toast.innerHTML = `
        <div class="d-flex">
            <div class="toast-body">
                ${message}
            </div>
            <button type="button" class="btn-close me-2 m-auto" data-bs-dismiss="toast" aria-label="Close"></button>
        </div>
    `;
    
    // Add to container
    const container = document.getElementById('toastContainer');
    container.appendChild(toast);
    
    // Initialize and show toast
    const bsToast = new bootstrap.Toast(toast);
    bsToast.show();
    
    // Remove toast after it's hidden
    toast.addEventListener('hidden.bs.toast', function() {
        container.removeChild(toast);
    });
}

// Open chatbot
function openChatbot() {
    showToast('سيتم فتح شات البوت قريباً', 'info');
}