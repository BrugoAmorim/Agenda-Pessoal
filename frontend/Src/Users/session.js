
export function infoUsuario(obj){

    localStorage.setItem('iduser', obj.iduser);
    localStorage.setItem('usuario', obj.usuario);
    localStorage.setItem('email', obj.email);
    localStorage.setItem('dtcriado', obj.criado);

    window.location.href = "../../Public/Pages/Menu/index.html";
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

export async function validarIdentidade(idconta, senha){

    let url = "http://localhost:5000/Usuarios/validar-usuario/" + idconta + "?senha=" + senha;

    const api = await fetch(url, {

        method: 'GET',
        mode: 'cors'
    });

    let res = api.json();
    res.then((data) => {

        if(data.codigo == 400)
            swal(data.mensagem, "", 'error')
        else
            window.location.href = "../MinhasInformacoes/info.html";
    })
}