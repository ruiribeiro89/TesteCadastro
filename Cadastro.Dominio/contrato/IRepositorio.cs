﻿using System.Collections.Generic;

namespace Cadastro.Dominio.contrato
{
    public interface IRepositorio<T> where T : class
    {
        void Salvar(T entidade);

        void Excluir(T entidade);

        IEnumerable<T> ListarTodos();

        T ListarPorId(string id);

    }
}
