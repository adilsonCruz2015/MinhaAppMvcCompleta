// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// marcação no video 08:08
function AjaxModal() {
    $(document).ready(function () {
        $(function () {
            $.ajaxSetup({ cache: false });

            $("a[data-modal]").on("click",
                function (e) {

                    $('#myModalContent').load(this.href,
                        function () {
                            $('#myModal').modal({ keyboard: true }, 'show');
                            bindForm(this);
                        });
                    return false;
                });
            
        });

        // parei no 13:37


        function bindForm(dialog) {
            $('form', dialog).submit(function () {
                $.ajax({
                    url: this.action,
                    type: this.method,
                    data: $(this).serialize(),
                    succes: function (result) {
                        if (result.succes) {
                            $('#myModal').modal('hide');
                            $('#EnderecoTarget').load(result.url); // carrega o resultado HTML para a div de
                        } else {
                            $('myModalContent').html(result);
                            bindForm(dialog);
                        }
                    }
                });
                return false;
            });
        }
    });    
}