(function () {
    angular.module('app').controller('app.views.products.index', [
        '$scope', '$timeout', '$uibModal', 'abp.services.app.product',
        function ($scope, $timeout, $uibModal, productService) {
            var vm = this;
            vm.product = [];

            function getUsers() {
                productService.getProducts({}).then(function (result) {
                    vm.product = result.data;
                    console.log(vm.product);
                });
            }
            getUsers();
        }
    ]);
})();

