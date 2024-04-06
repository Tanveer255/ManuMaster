$(function () {

    // DELETING ITEMS /////////////////////////////////////////
    $('#ProductList').on('click', 'li i', function () {
        var $li = $(this).parent();
        var id = $li.attr('data-id');

        ManuMaster.Services.Dtos.delete(id).then(function () {
            $li.remove();
            abp.notify.info('Deleted the todo item.');
        });
    });

    // CREATING NEW ITEMS /////////////////////////////////////
    $('#NewItemForm').submit(function (e) {
        e.preventDefault();
        var productText = $('#NewItemText').val();  
        ManuMaster.Services.Dtos.create(productText).then(function (result) {
            $('<li data-id="' + result.id + '">')
                .html('<i class="fa fa-trash-o"></i> ' + result.text)
                .appendTo($('#ProductList'));
            $('#NewItemText').val('');
            $('<li data-id="' + result.id + '">')
                .html('<i class="fa fa-trash-o"></i> ' + result.Price)
                .appendTo($('#ProductList'));
            $('#NewItemprice').val('');
            $('<li data-id="' + result.id + '">')
                .html('<i class="fa fa-trash-o"></i> ' + result.Quantity)
                .appendTo($('#ProductList'));
            $('#NewItemquantity').val('');
            $('<li data-id="' + result.id + '">')
                .html('<i class="fa fa-trash-o"></i> ' + result.Manufacture)
                .appendTo($('#ProductList'));
            $('#NewItemmanufacture').val('');
        });
    });
});
