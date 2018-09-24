taskManagementApp.config(function ($routeProvider, $locationProvider){
    console.log("route");
    $routeProvider.
        when('/CreateTask', {
        templateUrl: '/wwwroot/Pages/CreateTask.html',
        controller: 'taskController'
        })
});