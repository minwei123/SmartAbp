$(function () {
    var l = abp.localization.getResource('SmartAbp');

    var dataTable = $('#stationTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(smartAbp.stations.station.getList),
            columnDefs: [
                {
                    title: l('Name'),
                    data: "name"
                },
                {
                    title: l('Name'),
                    data: "name"
                }
            ]
        })
    );
});
