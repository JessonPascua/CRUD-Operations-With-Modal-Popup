// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {
    var PlaceHolderElement = $('#PlaceHolderHere');
    function makeElementDraggable() {
        PlaceHolderElement.find('.modal-content').draggable({
            handle: '.modal-header' // Allows dragging only from the header
        });
    }

    $('button[data-toggle="ajax-modal"]').on('click', function (event) {
        PlaceHolderElement = $('#PlaceHolderHere');
        var url = $(this).data('url');
        var decodedUrl = decodeURIComponent(url);
        $.get(decodedUrl).done(function (data) {

            PlaceHolderElement.html(data);
            PlaceHolderElement.find('.modal').modal('show');
            PlaceHolderElement.find('.modal').on('shown.bs.modal', function () {
                makeElementDraggable();
            });
        })
    });

    PlaceHolderElement.on('click', '[data-save="modal"]', function (event) {
        event.preventDefault();
        var form = $(this).parents('.modal').find('form');
        var actionUrl = form.attr('action');
        var sendData = form.serialize();

        $.post(actionUrl, sendData).done(function (data) {
            PlaceHolderElement.find('.modal').modal('hide');
        })
    })

});