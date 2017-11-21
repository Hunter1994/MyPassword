(function () {
    $(function () {

        var _infoService = abp.services.app.info;
        var _$modal = $('#InfoCreateModal');
        var _$form = _$modal.find('form');


        _$form.validate({
        });

        _$form.find('button[type="submit"]').click(function (e) {

            e.preventDefault();
            if (!_$form.valid()) return;

            var info = _$form.serializeFormToObject();

            abp.ui.setBusy(_$modal);

            _infoService.createInfo(info).done(function () {
                _$modal.modal('hide');
                refreshInfoList();//重新加载页面
            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });

        });

        $(".delete-info").click(function () {

            var infoId = $(this).attr("data-info-id");
            var infoName = $(this).attr("data-info-name");
            deleteInfo(infoId, infoName);

        });
        $(".edit-info").click(function (e) {
            var infoId = $(this).attr("data-info-id");
            e.preventDefault();

            $.ajax({
                url: abp.appPath + "Infos/EditInfoModal?id=" + infoId,
                type: "post",
                contentType: "application/html",
                success: function (content) {
                    $("#InfoEditModal div.modal-content").html(content);
                },
                error: function (e) { }
            })


        });




        $("#RefreshButton").click(function (){
            refreshInfoList();
        });

        function refreshInfoList() {
            location.reload(true);
        }
        function deleteInfo(infoId, infoName) {
            abp.message.confirm("是否删除用户：" + infoName + "?", function (isConfirmed) {
                if (isConfirmed) {
                    _infoService.deleteInfo(infoId).done(function () {
                        refreshInfoList();
                    })
                }

            });

        }


    });
})();

