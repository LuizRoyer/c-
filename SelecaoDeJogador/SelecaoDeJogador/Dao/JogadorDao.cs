using System;

namespace SelecaoDejogador.Dao
{

    public class JogadorDao
    {
        public JogadorDao()
        {
            base.Cn = new DB2Connection();
            base.IsParameter = false;
        }

        public JogadorDao(DB2Connection connection)
        {
            base.Cn = connection;
            base.IsParameter = true;
        }

        public int Insert(JogadorDto obj)
        {
            var sqlInsert = string.Empty;

            try
            {
                Cn.Open();
                sqlInsert = "INSERT INTO TabelaJogador ";
                sqlInsert += "(idJogaor";
                sqlInsert += "(NOME";
                sqlInsert += ", SOBRENOME";
                sqlInsert += ", POSICAO";
                sqlInsert += ", IDADE";
                sqlInsert += ", GENERO";
                sqlInsert += ", ALTURA";
                sqlInsert += ", PESO";
                sqlInsert += ", GOLSMARCADOS";
                sqlInsert += ", NUMERODEJOGOS";
                sqlInsert += ", QUANTIDADECARTAOAMARELO";
                sqlInsert += ", QUANTIDADECARTAOVERMELHO";
                sqlInsert += ", QUANTIDADEEXPULSAO";
                sqlInsert += ") VALUES (";

                sqlInsert += KConvert.ConvDB2(obj.IdJogador);
                sqlInsert += "," + KConvert.ConvDB2(obj.Nome);
                sqlInsert += "," + KConvert.ConvDB2(obj.Sobrenome);
                sqlInsert += "," + KConvert.ConvDB2(obj.Posicao);
                sqlInsert += "," + KConvert.ConvDB2(obj.Idade);
                sqlInsert += "," + KConvert.ConvDB2(obj.Genero);
                sqlInsert += "," + KConvert.ConvDB2(obj.Altura);
                sqlInsert += "," + KConvert.ConvDB2(obj.Peso);
                sqlInsert += "," + KConvert.ConvDB2(obj.GolsMarcados);
                sqlInsert += "," + KConvert.ConvDB2(obj.NumeroDeJogos);
                sqlInsert += "," + KConvert.ConvDB2(obj.QuantidadeCartaoAmarelo);
                sqlInsert += "," + KConvert.ConvDB2(obj.QuantidadeCartaoVermelho);
                sqlInsert += "," + KConvert.ConvDB2(obj.QuantidadeExpulsao);
                sqlInsert += ")";

                return Cn.Execute(sqlInsert);
            }
            catch (Exception ex)
            {
                throw new SQLException(Cn.activeConnection.Errors, sqlInsert, ex);
            }
            finally
            {
                if (!IsParameter) Cn.Close();
            }
        }

        public int Update(JogadorDto obj)
        {
            var sqlUpdate = string.Empty;

            try
            {
                Cn.Open();
                sqlUpdate += " IDJOGADOR = " + Convert.ConvDB2(obj.IdJogador);
                sqlUpdate += ",NOME = " + Convert.ConvDB2(obj.Nome);
                sqlUpdate += ",SOBRENOME = " + Convert.ConvDB2(obj.Sobrenome);
                sqlUpdate += " ,POSICAO = " + Convert.ConvDB2(obj.Posicao);
                sqlUpdate += ",IDADE = " + Convert.ConvDB2(obj.Idade);
                sqlUpdate += ",GENERO = " + Convert.ConvDB2(obj.Genero);
                sqlUpdate += ",ALTURA = " + Convert.ConvDB2(obj.Altura);
                sqlUpdate += ",PESO = " + Convert.ConvDB2(obj.Peso);
                sqlUpdate += ",GOLSMARCADOS = " + Convert.ConvDB2(obj.GolsMarcados);
                sqlUpdate += ",NUMERODEJOGOS = " + Convert.ConvDB2(obj.NumeroDeJogos);
                sqlUpdate += ",QUANTIDADECARTAOAMARELO = " + Convert.ConvDB2(obj.QuantidadeCartaoAmarelo);
                sqlUpdate += ",QUANTIDADECARTAOVERMELHO = " + Convert.ConvDB2(obj.QuantidadeCartaoVermelho);
                sqlUpdate += ",QUANTIDADEEXPULSAO = " + Convert.ConvDB2(obj.QuantidadeExpulsao);
                sqlUpdate += " WHERE IDJOGADOR = " + Convert.ConvDB2(obj.EdJogador);
                sqlUpdate += "  AND NOME  = " + Convert.ConvDB2(obj.Nome);

                return Cn.Execute(sqlUpdate);
            }
            catch (Exception ex)
            {
                throw new SQLException(Cn.activeConnection.Errors, sqlUpdate, ex);
            }
            finally
            {
                if (!IsParameter) Cn.Close();
            }
        }


        public int Delete(JogadorDto obj)
        {
            var sqlDelete = string.Empty;

            try
            {
                Cn.Open();
                sqlDelete = "DELETE FROM TabelaJogador ";
                sqlDelete += " WHERE IDJOGADOR = " + KConvert.ConvDB2(obj.IdJogador);
                sqlDelete += "  AND NOME  = " + KConvert.ConvDB2(obj.Nome);
                return Cn.Execute(sqlDelete);
            }
            catch (Exception ex)
            {
                throw new SQLException(Cn.activeConnection.Errors, sqlDelete, ex);
            }
            finally
            {
                if (!IsParameter) Cn.Close();
            }
        }


        public JogadorDto GetAsObject(JogadorDto filtro)
        {
            return ConvertRsToObject(DefaultSelect(filtro));
        }

        public System.Collections.Generic.List<JogadorDto> GetAsList(JogadorDto filtro)
        {
            return ConvertRsToList(DefaultSelect(filtro));
        }

        public System.Data.DataTable GetAsDatatable(JogadorDto filtro)
        {
            return ConvertRsToDataTable(DefaultSelect(filtro));
        }



        public ADODB.Recordset DefaultSelect(Ca020Dto filtro)
        {
            var sqlSelect = String.Empty;

            try
            {
                Cn.Open();
                sqlSelect = "SELECT ";
                sqlSelect += "IDJOGADOR AS IDJOGADOR";
                sqlSelect += "NOME AS NOME";
                sqlSelect += "SOBRENOME AS SOBRENOME";
                sqlSelect += "POSICAO AS POSICAO";
                sqlSelect += "IDADE AS IDADE";
                sqlSelect += "CHAR(GENERO) AS GENERO";
                sqlSelect += "ALTURA AS ALTURA";
                sqlSelect += "PESO AS PESO";
                sqlSelect += "GOLSMARCADOS AS GOLSMARCADOS";
                sqlSelect += "NUMERODEJOGOS AS NUMERODEJOGOS";
                sqlSelect += "QUANTIDADECARTAOAMARELO AS QUANTIDADECARTAOAMARELO";
                sqlSelect += "QUANTIDADECARTAOVERMELHO AS QUANTIDADECARTAOVERMELHO";
                sqlSelect += "QUANTIDADEEXPULSAO AS QUANTIDADEEXPULSAO";

                sqlSelect += " FROM TabelaJogador ";

                if (filtro.IdJogador != 0)
                {
                    sqlSelect += " WHERE IDJOGADOR = " + KConvert.ConvDB2(filtro.IdJogador);
                }
                if (!String.IsNullOrWhiteSpace(filtro.Nome))
                {
                    sqlSelect += "  AND NOME  = " + KConvert.ConvDB2(filtro.Nome);
                }

                if (!String.IsNullOrWhiteSpace(filtro.Sobrenome))
                {
                    sqlSelect += "  AND SOBRENOME  >= " + KConvert.ConvDB2(filtro.Sobrenome);
                }

                if (!String.IsNullOrWhiteSpace(filtro.Posicao))
                {
                    sqlSelect += "  AND  Posicao <= " + KConvert.ConvDB2(filtro.Posicao);
                }

                if (!String.IsNullOrWhiteSpace(filtro.Idade))
                {
                    sqlSelect += "  AND Idade  = " + KConvert.ConvDB2(filtro.Idade);
                }

                if (!String.IsNullOrWhiteSpace(filtro.Genero))
                {
                    sqlSelect += "  AND Geneto  = " + KConvert.ConvDB2(filtro.Genero);
                }
                if (filtro.Altura != 0)
                {
                    sqlSelect += " AND Altura = " + KConvert.ConvDB2(filtro.Altura);
                }
                if (filtro.Peso != 0)
                {
                    sqlSelect += " AND Peso = " + KConvert.ConvDB2(filtro.Peso);
                }
                if (filtro.GolsMarcados != 0)
                {
                    sqlSelect += " AND GolsMarcados = " + KConvert.ConvDB2(filtro.GolsMarcados);
                }

                if (!String.IsNullOrWhiteSpace(filtro.NumeroDeJogos))
                {
                    sqlSelect += " AND NumeroDeJogos = " + KConvert.ConvDB2(filtro.NumeroDeJogos);
                }
                if (!String.IsNullOrWhiteSpace(filtro.QuantidadeCartaoAmarelo))
                {
                    sqlSelect += " AND QuantidadeCartaoAmarelo = " + KConvert.ConvDB2(filtro.QuantidadeCartaoAmarelo);
                }
                if (!String.IsNullOrWhiteSpace(filtro.QuantidadeCartaoVermelho))
                {
                    sqlSelect += " AND QuantidadeCartaoVermelho = " + KConvert.ConvDB2(filtro.QuantidadeCartaoVermelho);
                }
                if (!String.IsNullOrWhiteSpace(filtro.QuantidadeExpulsao))
                {
                    sqlSelect += " AND QuantidadeExpulsao = " + KConvert.ConvDB2(filtro.QuantidadeExpulsao);
                }

                sqlSelect += " WITH UR ";

                return KRecordSet.Open(sqlSelect, Cn);
            }
            catch (Exception ex)
            {
                throw new SQLException(Cn.activeConnection.Errors, sqlSelect, ex);
            }
        }



        public List<JogadorDto> ConvertRsToList(Recordset rs)
        {
            var objectList = new List<JogadorDto>();

            try
            {
                if (KRecordSet.IsValid(rs))
                {
                    while (!rs.EOF)
                    {
                        var obj = new JogadorDto()
                        {
                            IdJogador = Convert.ToDouble(rs.Fields["IDJOGADOR"].Value),
                            Nome = rs.Fields["NOME"].Value.Trim(),
                            Sobrenome = rs.Fields["SOBRENOME"].Value.Trim(),
                            Posicao = rs.Fields["POSICAO"].Value.Trim(),
                            Idade = Convert.ToByte(rs.Fields["IDADE"].Value),
                            Genero = Convert.ToChar(rs.Fields["CDEQPTIC"].Value),
                            Altura = Convert.Tofloat(rs.Fields["ALTURA"].Value),
                            Peso = Convert.Tofloat(rs.Fields["PESO"].Value),
                            GolsMarcados = Convert.toInt(rs.Fields["GOLSMARCADOS"].Value),
                            NumeroDeJogos = Convert.toInt(rs.Fields["NUMERODEJOGOS"].Value),
                            QuantidadeCartaoAmarelo = Convert.toInt(rs.Fields["QUANTIDADECARTAOAMARERLO"].Value),
                            QuantidadeCartaoVermelho = Convert.toInt(rs.Fields["QUANTIDADECARTAOVERMELHO"].Value),
                            QuantidadeExpulsao = Convert.toInt(rs.Fields["QUANTIDADEEXPULSAO"].Value),
                        };
                        objectList.Add(obj);
                        rs.MoveNext();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Ocorreu um erro ao converter RecordSet em Lista.", ex);
            }
            finally
            {
                rs.Close();
                if (!IsParameter) Cn.Close();
            }

            return objectList;
        }



        public JogadorDto ConvertRsToObject(Recordset rs)
        {
            Ca020Dto obj = null;
            try
            {
                if (KRecordSet.IsValid(rs))
                {
                    if (rs.RecordCount == 1)
                    {
                        obj = new JogadorDto()
                        {

                            IdJogador = Convert.ToDouble(rs.Fields["IDJOGADOR"].Value),
                            Nome = rs.Fields["NOME"].Value.Trim(),
                            Sobrenome = rs.Fields["SOBRENOME"].Value.Trim(),
                            Posicao = rs.Fields["POSICAO"].Value.Trim(),
                            Idade = Convert.ToByte(rs.Fields["IDADE"].Value),
                            Genero = Convert.ToChar(rs.Fields["CDEQPTIC"].Value),
                            Altura = Convert.Tofloat(rs.Fields["ALTURA"].Value),
                            Peso = Convert.Tofloat(rs.Fields["PESO"].Value),
                            GolsMarcados = Convert.toInt(rs.Fields["GOLSMARCADOS"].Value),
                            NumeroDeJogos = Convert.toInt(rs.Fields["NUMERODEJOGOS"].Value),
                            QuantidadeCartaoAmarelo = Convert.toInt(rs.Fields["QUANTIDADECARTAOAMARERLO"].Value),
                            QuantidadeCartaoVermelho = Convert.toInt(rs.Fields["QUANTIDADECARTAOVERMELHO"].Value),
                            QuantidadeExpulsao = Convert.toInt(rs.Fields["QUANTIDADEEXPULSAO"].Value),


                        };
                    }
                    else if (rs.RecordCount > 1)
                    {
                        throw new DataException("RecordSet passado como parâmetro tem mais de um registro.");
                    }
                }
            }
            catch (KarstenException ke)
            {
                throw new DataException("Ocorreu um erro ao converter RecordSet em objeto.", ke);
            }
            finally
            {
                rs.Close();
                if (!IsParameter) Cn.Close();
            }

            return obj;
        }

        public double NextValue()
        {
            var sqlSelect = String.Empty;
            var rs = new Recordset();
            try
            {
                Cn.Open();
                sqlSelect = "VALUES NEXTVAL FOR TabelaJogador";


                rs = KRecordSet.Open(sqlSelect, Cn);

                if (!rs.EOF)
                {
                    return Convert.ToDouble(rs.Fields[0].Value);
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new SQLException(Cn.activeConnection.Errors, sqlSelect, ex);
            }
            finally
            {
                rs.Close();
                Cn.Close();
            }
        }


    }
}