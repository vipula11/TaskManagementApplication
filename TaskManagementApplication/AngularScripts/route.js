taskManagementApp.config(function ($routeProvider, $locationProvider){
    console.log("route");
    $routeProvider.
        when('/', {
        templateUrl: '/htmlPages/createDashboard.html',
        controller: 'homeController'
        })
});