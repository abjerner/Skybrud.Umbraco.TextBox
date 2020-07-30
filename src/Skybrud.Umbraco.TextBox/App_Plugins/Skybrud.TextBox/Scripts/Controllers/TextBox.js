angular.module("umbraco").controller("Skybrud.TextBox.Controller", function ($scope, localizationService) {

    if (!$scope.model.value) $scope.model.value = "";

    // Initialize the configuration
    var limit = parseInt($scope.model.config.maxChars) || 0;
    var enforce = Object.toBoolean($scope.model.config.enforce);

    $scope.update = function () {

        if (limit < 1) {
            $scope.info = null;
            return;
        }

        if ($scope.model.value.length > limit && enforce) {
            $scope.info = `You cannot write more than <strong class="negative">${limit}</strong> characters!`;

            localizationService.localize("skyTextBox_info3", [limit]).then(function (value) {
                $scope.info = value;
            });

            $scope.model.value = $scope.model.value.substr(0, limit);

        } else {

            const remaining = (limit - $scope.model.value.length);

            if ($scope.model.value.length > limit) {
                localizationService.localize("skyTextBox_info2", [remaining]).then(function (value) {
                    $scope.info = value;
                });
            } else {
                localizationService.localize("skyTextBox_info1", [remaining]).then(function (value) {
                    $scope.info = value;
                });
            }

        }

    };

    $scope.update();

});