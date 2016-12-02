(function () {

    // Registering a controller as a named function (instead of anonymous function)
    angular
        .module('main-app')
        .component('paginationControl', {
            bindings: {
                noOfRows: '<',
                pageSize: '<'
            },
            templateUrl: 'pagination-control-template.html',
            controller: function () {

                var self = this;

                self.ShowPagination = false;
                self.PageIndex = 1;
                self.LastPage = 0;
                self.Pages = [];

                // Display pagination if no of rows is more than page size.
                if (self.pageSize <= self.noOfRows) {

                    self.ShowPagination = true
                    self.EndLinks = true;
                    self.DirectionLinks = true;

                    self.LastPage = Math.floor(self.noOfRows / self.pageSize);

                    if ((self.noOfRows % self.pageSize) > 0) {
                        self.LastPage++;
                    }

                    for (var i = 1; i <= self.LastPage; i++) {
                        self.Pages.push(i);
                    }
                }

                self.SetPageIndex = function (pageIndex) {
                    self.PageIndex = pageIndex;
                    console.log(self);
                };

            }
        })
})();