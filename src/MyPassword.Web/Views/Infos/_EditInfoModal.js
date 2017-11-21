(function ($) {
    var _infoService = abp.services.app.info;
    var _$modal = $("#InfoEditModal");
    var _$form = $("form[name=InfoEditForm]");

    function save() {
        if (!_$form.valid()) return;

        var info = _$form.serializeFormToObject();

        abp.ui.setBusy(_$form);
        _infoService.editInfo(info).done(function () {
            _$modal.modal('hide');
            location.reload(true);
        }).always(function () {
            abp.ui.clearBusy(_$form);
        });

    }

    _$form.closest("div.modal-content").find(".save-button").click(function (e) {
        e.preventDefault();
        save();
    })

    _$form.find("input").on("keypress", function (e) {
        if (e.which == 13) {
            e.preventDefault();
            save();
        }
    })
   
    _$modal.on('shown.bs.modal', function () {
        _$form.find("input[type=text]:first").foucs();
    })






})(jQuery)