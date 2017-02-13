﻿app.controller('StudentController', function ($scope, StudentService) {
    $scope.message = 'StudentController';
    
    getStudents();
    function getStudents() {
        StudentService.getStudents()
            .success(function (studs) {
                $scope.students = studs;
                console.log($scope.students);
            })
            .error(function (error) {
                $scope.status = 'Unable to load customer data: ' + error.message;
                console.log($scope.status);
            });
    }
})

app.factory('StudentService', ['$http', function ($http) {
    debugger;
    var StudentService = {};
    StudentService.getStudents = function () {
        return $http.get('/Home/GetPesrons');
    };
    return StudentService;

}]);
