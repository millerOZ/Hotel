$(document).ready(function () {
   
    $("#btnLogin").click(function () {
        ProcesarComandos();
    });
   
});


function ProcesarComandos() {
    var usuario = $("#txtUser").val();
    var contrasenia = $("#txtPassword").val();

    var login = {
        usuario: usuario,
        contrasenia: contrasenia,
    }
    $.ajax({
        //Función Ajax
        type: "POST",
        url: "../Controladores/BibliotecaControlador.ashx",
        contentType: "json",
        data: JSON.stringify(login),
        success: function (RespuestaProducto) {
            //Hay que procesar la respuesta para identificar si hay un error
            $("#dvMensaje").addClass("alert alert-success");
            $("#dvMensaje").html(RespuestaProducto);
        },
        error: function (RespuestaError) {
            $("#dvMensaje").addClass("alert alert-danger");
            $("#dvMensaje").html(RespuestaError);
        }
    });
}