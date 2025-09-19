function showSearchModal() {
    $('#searchModal').modal('show');
}

function searchMedicines() {
    var term = $('#searchInput').val().trim();
    if (term) {
        performSearch(term);
    } else {
        // Reset to full list if search term is empty
        performSearch('');
    }
}

function performSearch(term) {
    $.ajax({
        url: '/Medicines/Search',
        type: 'GET',
        data: { term: term },
        success: function (data) {
            $('#medicinesGrid').html(data);
        },
        error: function (xhr) {
            console.error('Search error:', xhr.responseText);
            alert('فشل البحث. يرجى المحاولة مرة أخرى.');
        }
    });
}

function filterByCategory(category) {
    if (!category || category === 'all') {
        $.ajax({
            url: '/Medicines/Index',
            type: 'GET',
            data: { category: 'all' },
            success: function (data) {
                $('#medicinesGrid').html($(data).find('#medicinesGrid').html());
            },
            error: function (xhr) {
                console.error('Category filter error:', xhr.responseText);
                alert('فشل تصفية الفئة. يرجى المحاولة مرة أخرى.');
            }
        });
    } else {
        $.ajax({
            url: '/Medicines/GetByCategory',
            type: 'GET',
            data: { category: category },
            success: function (data) {
                $('#medicinesGrid').html(data);
            },
            error: function (xhr) {
                console.error('Category filter error:', xhr.responseText);
                alert('فشل تصفية الفئة. يرجى المحاولة مرة أخرى.');
            }
        });
    }
}

function performAdvancedSearch() {
    var term = $('#searchKeywords').val().trim();
    var category = $('#searchCategory').val();

    var queryParams = {};
    if (term) queryParams.term = term;
    if (category && category !== '') queryParams.category = category;

    $.ajax({
        url: '/Medicines/Index',
        type: 'GET',
        data: queryParams,
        success: function (data) {
            $('#medicinesGrid').html($(data).find('#medicinesGrid').html());
            $('#searchModal').modal('hide');
        },
        error: function (xhr) {
            console.error('Advanced search error:', xhr.responseText);
            alert('فشل البحث المتقدم. يرجى المحاولة مرة أخرى.');
        }
    });
}

function loadMoreMedicines() {
    alert('Load more functionality to be implemented');
}