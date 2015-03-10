(function () {

  angular.module("myW", ["kendo.directives"])
    .controller("WeightCtrl", weightCtrl);

  function weightCtrl($scope) {

    var vm = $scope;

    vm.weight = new kendo.data.DataSource({
      transport: {
        read: {
          url: "../Content/Data/weight.json",
          dataType: "json"
        }
      },
      sort: {
        field: "date",
        dir: "asc"
      }
    });
  }

})();