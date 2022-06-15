"use strict";

$(document).ready(function () {
  $("#errorName").hide();
  $("#errorLname").hide();
  $("#errorBirth").hide();
  $("#errorMail").hide();
  $("#errorPhone").hide();
  $("#name").focus(function () {
    $("input#name").val("");
  });
  $("#lname").focus(function () {
    $("input#lname").val("");
  });
  $("#birth").focus(function () {
    $("input#birth").val("");
  });
  $("#mail").focus(function () {
    $("input#mail").val("");
  });
  $("#phone").focus(function () {
    $("input#phone").val("");
  });
  $("#button").click(function (e) {
    e.preventDefault();
    var phone = $("input#phone").val();

    if (phone == "") {
      $("#errorPhone").show();
      return false;
    } else if (phone == "Ingrese su número de teléfono") {
      $("#errorPhone").show();
      return false;
    }
  });
  $("#button").click(function (e) {
    e.preventDefault();
    var mail = $("input#mail").val();

    if (mail == "") {
      $("#errorMail").show();
      return false;
    } else if (mail == "Ingrese su email") {
      $("#errorMail").show();
      return false;
    }
  });
  $("#button").click(function (e) {
    e.preventDefault();
    var birth = $("input#birth").val();

    if (birth == "") {
      $("#errorBirth").show();
      return false;
    } else if (birth == "Ingrese su fecha de nacimiento") {
      $("#errorBirth").show();
      return false;
    }
  });
  $("#button").click(function (e) {
    e.preventDefault();
    var name = $("input#name").val();

    if (name == "") {
      $("#errorName").show();
      return false;
    } else if (name == "Ingrese su nombre") {
      $("#errorName").show();
      return false;
    }
  });
  $("#button").click(function (e) {
    e.preventDefault();
    var lname = $("input#lname").val();

    if (lname == "") {
      $("#errorLname").show();
      return false;
    } else if (lname == "Ingrese su apellido") {
      $("#errorLname").show();
      return false;
    }
  });
});
$(function () {
  $("#birth").on("change", calcularEdad);
});

function calcularEdad() {
  var fecha = $(this).val();
  var hoy = new Date();
  var cumpleanos = new Date(fecha);
  var edad = hoy.getFullYear() - cumpleanos.getFullYear();
  var m = hoy.getMonth() - cumpleanos.getMonth();

  if (m < 0 || m === 0 && hoy.getDate() < cumpleanos.getDate()) {
    edad--;
  }

  $("#age").val(edad);
}

$(document).ready(function () {
  $("#button2").click(function (e) {
    e.preventDefault();
    $("input#name, #lname, #birth, #age, #mail, #phone").val("");
  });
});
$("#button").click(function (e) {
  e.preventDefault();
  var namecomplet = $("input#name").val();
  var lnamecomplet = $("input#lname").val();
  var birthcomplet = $("input#birth").val();
  var agecomplet = $("input#age").val();
  var mailcomplet = $("input#mail").val();
  var phonecomplet = $("input#phone").val();

  if (namecomplet != "" && lnamecomplet != "" && birthcomplet != "" && agecomplet != "" && mailcomplet != "" && phonecomplet != "") {
    alert("Formulario enviado");
  }
});