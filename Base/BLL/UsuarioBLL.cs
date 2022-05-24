﻿using DAL;
using Model;
using System.Data;

namespace BLL
{
    public class UsuarioBLL
    {
        public Usuario Inserir(Usuario _usuario)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.Inserir(_usuario);
        }
        public DataTable Buscar(string _filtro)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.Buscar(_filtro);
        }
        public Usuario Alterar(Usuario _usuario)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.Alterar(_usuario);
        }
        public void Excluir(int _id)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Excluir(_id);
        }
    }
}