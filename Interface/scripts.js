angular.module("foneList", []);
angular.module("foneList").controller("foneListController", function ($scope) {
  $scope.appName = "Fone List";
  $scope.clients = [
    {
      name: "joao",
      fone: "(11)0000-1111",
    },
    {
      name: "pedro",
      fone: "(11)1111-2222",
    },
    {
      name: "luka",
      fone: "(11)2222-1111",
    },
    {
      name: "zé",
      fone: "(11)1111-0000",
    },
    {
      name: "pé",
      fone: "(11)0000-2222",
    },
  ];

  $scope.addClient = function (client) {
    $scope.clients.push(angular.copy(client));
    delete $scope.client;
  };

  $scope.deleteClient = function (clients) {
    $scope.clients = clients.filter(function (client) {
      if (!client.check) return client;
    });
  };
});
