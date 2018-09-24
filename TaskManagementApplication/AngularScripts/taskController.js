taskManagementApp.controller('taskController', ['$scope', '$location', '$http', '$route', function ($scope, $location, $http, $route) {


    $scope.$watch('title', function () {
        $scope.title = $scope.title;
    });

    $scope.$watch('description', function () {
        $scope.description = $scope.description;
    });

    $scope.$watch('assignee', function () {
        $scope.assignee = $scope.assignee;

    });
    $scope.$watch('reporter', function () {
        $scope.reporter = $scope.reporter;
    });

    $scope.$watch('comments', function () {
        $scope.comments = $scope.comments;
    });

    $scope.$watch('duration', function () {
        $scope.duration = $scope.duration;
    });

    $scope.addTask = function () {
        $scope.taskDetails = {

            title: $scope.title,
            description: $scope.description, 
            assignee: $scope.assignee,
            reporter: $scope.reporter, 
            comments: $scope.comments, 
            duration: $scope.duration


        }
        console.log($scope.taskDetails);
        result = $http({
            method: 'POST',
            url: '/Home/CreateTask',
            data: {
                taskDetails: $scope.taskDetails
            },

            headers: {
                "Content-Type": "application/json"
            }

        }).then(function (response) {


       


        }), (function (response) {
            console.log("Error");

        });
        }
    }
]);