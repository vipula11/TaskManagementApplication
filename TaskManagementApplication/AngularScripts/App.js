var taskManagementApp = angular.module('taskManagementApp', ['ngRoute', 'ngResource', 'ui.bootstrap']);

console.log("App");

taskManagementApp.config(function ($routeProvider, $locationProvider) {
    console.log('route');
    $routeProvider.
        when('/', {
            templateUrl: '/htmlPages/createDashboard.html',
            controller: 'homeController',
        })

});

taskManagementApp.controller('homeController', ['$scope', '$location', '$http', '$route', function ($scope, $location, $http, $route) {

    


}]);