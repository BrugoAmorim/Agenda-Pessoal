
export function infoUsuario(obj){

    localStorage.setItem('iduser', obj.iduser);
    localStorage.setItem('usuario', obj.usuario);
    localStorage.setItem('email', obj.email);
    localStorage.setItem('dtcriado', obj.criado);

    window.location.href = "../../Pages/Home/index.html";
}

export function lerInfoUsuario(){

    let objRes = {
        id: localStorage.getItem('iduser'),
        usuario: localStorage.getItem('usuario'),
        email: localStorage.getItem('email'),
        criado: localStorage.getItem('dtcriado')
    };

    return objRes;
}

export function apagarInfoUsuario(){

    localStorage.removeItem('iduser');
    localStorage.removeItem('usuario');
    localStorage.removeItem('email');
    localStorage.removeItem('dtcriado');
}