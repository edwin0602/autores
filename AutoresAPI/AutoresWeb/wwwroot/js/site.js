// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
const apiBase = "https://localhost:44380";

const serviceEditorial = {
    obtenerEditoriales : function (resolve) {
        $.get(`${apiBase}/api/Editoriales`, resolve);
    },
    guardarEditorial: function (toSend, resolve, error) {
        $.ajax({
            url: `${apiBase}/api/Editoriales`,
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(toSend),
            success: resolve,
            error: error
        });
    }
}

const serviceLibro = {
    obtenerLibros: function (resolve) {
        $.get(`${apiBase}/api/Libros`, resolve);
    },
    guardarLibro: function (toSend, resolve, error) {
        $.ajax({
            url: `${apiBase}/api/Libros`,
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(toSend),
            success: resolve,
            error: error
        });
    }
}

const serviceAutor = {
    obtenerAutores: function (resolve) {
        $.get(`${apiBase}/api/Autores`, resolve);
    }
}
