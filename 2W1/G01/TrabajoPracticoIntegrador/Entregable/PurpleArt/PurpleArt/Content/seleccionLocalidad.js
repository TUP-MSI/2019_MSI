function elegirPais(lista, lista2){
    console.log(lista);
    cadenaHTML="";
    paisId = document.getElementById("paisSelect").value
    lista.forEach(element => {
        if (element.Pais.IdPais == paisId){
            cadenaHTML += "<option value=\"" + element.IdProvincia  + "\">"+element.NombreProvincia+"</option>"
        }
    });
    provinciaSelect= document.getElementById("provinciaSelect");
    provinciaSelect.innerHTML = cadenaHTML;
    elegirProvincia(lista2)
}

function elegirProvincia(lista){
    console.log(lista);
    cadenaHTML="";
    pId = document.getElementById("provinciaSelect").value
    lista.forEach(element => {
        if (element.Provincia.IdProvincia == pId){
            cadenaHTML += "<option value=\"" + element.IdLocalidad  + "\">"+element.NombreLocalidad+"</option>"
        }
    });
    provinciaSelect= document.getElementById("localidadSelect");
    provinciaSelect.innerHTML = cadenaHTML;
}


