(function () {
    $(function () {
        var _appService = abp.services.app.product;
        var _$modal = $("#ProductCreateModal");
        var _$form = _$modal.find("form");

        $("#RefreshButton").click(function () {
            refresh();
        })

        _$form.find('button[type="submit"]').click(function (e) {
            e.preventDefault();
            if (!_$form.valid()) returnl
            var product = _$form.serializeFormToObject();
            abp.ui.setBusy(_$modal);
            _appService.create(product).done(function () {
                _$modal.hide('hide');
                refresh();
            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });
        });


        function refresh()
        {
            location.reload(true);
        }


    });
})();