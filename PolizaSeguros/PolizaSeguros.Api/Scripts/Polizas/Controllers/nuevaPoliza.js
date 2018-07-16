(function () {
    angular.module("AppModulePolicy")
        .controller("nuevaPolizaCtrl",
            [
                "$scope",
                "$filter",
                "$q",
                "TipoRiesgoService",
                "$window",
                "$location",
                function ($scope, $filter, $q, TipoRiesgoService, $window, $location) {

                    $scope.solicitud = {};
                    $scope.tiposRiesgos = [];

                    TipoRiesgoService.getAll().then(function (resultados) {
                        $scope.tiposRiesgos = resultados[0];
                    });             
                }
             ]);

})();