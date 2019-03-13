using System;

namespace SelecaoDejogador.Bll
{

    public class JogadorBll
    {
        private Ca020Dao Dao;

        public JogadorBll()
        {
            this.Dao = new JogadorDao();
        }

        public JogadorBll(DB2Connection connection)
        {
            this.Dao = new JogadorDao(connection);
        }


        public int Insert(JogadorDto obj)
        {
            var affectedRows = 0;

            if (obj != null)
            {
                affectedRows = this.Dao.Insert(obj);

                if (affectedRows == 0)
                    throw new BusinessException("Nenhum registro foi inserido, verifique os dados informados.");
            }
            else
                throw new ArgumentNullException("Objeto passado como parâmetro está nulo.");

            return affectedRows;
        }


        public int Update(JogadorDto obj)
        {
            var affectedRows = 0;

            if (obj != null)
            {
                affectedRows = this.Dao.Update(obj);

                if (affectedRows == 0)
                    throw new BusinessException("Nenhum registro foi atualizado, verifique o filtro informado.");
            }
            else
                throw new ArgumentNullException("Objeto passado como parâmetro está nulo.");

            return affectedRows;
        }


        public int Delete(JogadorDto obj)
        {
            var affectedRows = 0;

            if (obj != null)
            {
                affectedRows = this.Dao.Delete(obj);

                if (affectedRows == 0)
                    throw new BusinessException("Nenhum registro foi removido, verifique o filtro informado.");
            }
            else
                throw new ArgumentNullException("Objeto passado como parâmetro está nulo.");

            return affectedRows;
        }

        public JogadorDto GetAsObject(JogadorDto filtro)
        {
            return this.Dao.GetAsObject(filtro);
        }

        public System.Collections.Generic.List<JogadorDto> GetAsList(JogadorDto filtro)
        {
            return this.Dao.GetAsList(filtro);
        }

        public System.Data.DataTable GetAsDatatable(JogadorDto filtro)
        {
            return this.Dao.GetAsDatatable(filtro);
        }

    }
}