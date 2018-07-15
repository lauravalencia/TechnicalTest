(function () {
    angular.module("AppModulePolicy")
        .factory("TipoRiesgoService", ["baseSvc", function (baseService) {
            var getAll = function () {
                var query = listEndPoint + "/GetByTitle('Áreas')/Items?$select=ID,Title,Destino,SubSitioDestino,NombreInternoListaDestino&$orderby=Title";
                return baseService.getRequest(query);
            };
            return {

                getAll: getAll,
                getById: getById,
                removebyId: removebyId
            };
        }]);
})();