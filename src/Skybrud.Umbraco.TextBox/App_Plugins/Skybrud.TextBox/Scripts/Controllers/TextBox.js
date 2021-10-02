angular.module("umbraco").controller("Skybrud.TextBox.Controller", function ($scope, localizationService) {

    const vm = this;

    vm.update = function () {

        if (vm.limit < 1) {
            vm.info = null;
            return;
        }

        if ($scope.model.value.length > vm.limit && vm.enforce) {

            vm.info = `You cannot write more than <strong class="negative">${vm.limit}</strong> characters!`;

            localizationService.localize("skyTextBox_info3", [vm.limit]).then(function (value) {
                vm.info = value;
            });

            $scope.model.value = $scope.model.value.substr(0, vm.limit);

        } else {

            const remaining = (vm.limit - $scope.model.value.length);

            if ($scope.model.value.length > vm.limit) {
                localizationService.localize("skyTextBox_info2", [remaining]).then(function (value) {
                    vm.info = value;
                });
            } else {
                localizationService.localize("skyTextBox_info1", [remaining]).then(function (value) {
                    vm.info = value;
                });
            }

        }

    };

    function init() {

        if (!$scope.model.value) $scope.model.value = "";
        if (!$scope.model.config) $scope.model.config = {};

        // Initialize the configuration
        vm.limit = parseInt($scope.model.config.maxChars) || 0;
        vm.enforce = Object.toBoolean($scope.model.config.enforce);
        vm.placeholder = $scope.model.config.placeholder;

        // If the placeholder starts with a hash, it's most likely a translation
        if (vm.placeholder && vm.placeholder.indexOf("#") === 0) {
            localizationService.localize(vm.placeholder.substr(1)).then(function (value) {
                if (value.indexOf("[") === 0) return;
                vm.placeholder = value;
            });
        }

        vm.update();

    };

    init();

});