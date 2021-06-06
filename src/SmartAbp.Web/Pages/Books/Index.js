$(function () {
    var l = abp.localization.getResource('BookStore');
    var editModal = new abp.ModalManager(abp.appPath + 'Books/EditModal');
    var dataTable = $('#BooksTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(smartAbp.books.book.getList),
            columnDefs: [
                {
                    title: l('操作'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('修改'),
                                    action: function (data) {
                                        editModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    text: l('删除'),
                                    confirmMessage: function (data) {
                                        return l('你确定要删除吗', data.record.name);
                                    },
                                    action: function (data) {
                                        smartAbp.books.book
                                            .delete(data.record.id)
                                            .then(function () {
                                                abp.notify.info(l('删除成功'));
                                                dataTable.ajax.reload();
                                            });
                                    }
                                }
                            ]
                    }
                },
                {
                    title: l('名称'),
                    data: "name"
                },
                {
                    title: l('类型'),
                    data: "type",
                    render: function (data) {
                        return l('Enum:BookType:' + data);
                    }
                },
                {
                    title: l('发布时间'),
                    data: "publishDate",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString();
                    }
                },
                {
                    title: l('价格'),
                    data: "price"
                },
                {
                    title: l('创建时间'), data: "creationTime",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString(luxon.DateTime.DATETIME_SHORT);
                    }
                }
              

            ]
        })
    );

    var createModal = new abp.ModalManager(abp.appPath + 'Books/CreateModal');

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });
    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewBookButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });

});