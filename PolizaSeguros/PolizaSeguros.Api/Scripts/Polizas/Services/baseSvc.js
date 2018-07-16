"use strict";
    (function () {
        angular.module("AppModulePolicy")
            .factory("baseSvc", ["$http", "$q", function ($http, $q) {

                var getRequest = function (query) {
                    var deferred = $q.defer();
                    $http({
                        url: window.location.origin + query,
                        method: "GET",
                        headers: {
                            "accept": "application/json;odata=verbose",
                            "content-Type": "application/json;odata=verbose"
                        }
                    })
                        .success(function (result) {
                            deferred.resolve(result);
                        })
                        .error(function (result, status) {
                            deferred.reject(status);
                        });
                    return deferred.promise;
                };
                var postRequest = function (data, url) {
                    var deferred = $q.defer();
                    $http({
                        url: window.location.origin + url,
                        method: "POST",
                        headers: {
                            "accept": "application/json;odata=verbose",
                            "X-RequestDigest": document.getElementById("__REQUESTDIGEST").value,
                            "content-Type": "application/json;odata=verbose"
                        },
                        data: JSON.stringify(data)
                    })
                        .success(function (result) {
                            deferred.resolve(result);
                        })
                        .error(function (result, status) {
                            deferred.reject(status);
                        });
                    return deferred.promise;
                };
                return {
                    getRequest: getRequest,
                    postRequest: postRequest
                };
            }]);
    })();