using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using AlbumFigPoliticos.Generics;

namespace AlbumFigPoliticos.Classes.Estáticas
{
    static class Cache
    {
        // Classe que apenas verifica se existe um partido com o nome, e retorna um objeto Partido
        public static Partido RetornoPartido(string nome)
        {
            LinkedList<Partido> part = new LinkedList<Partido>();
            part = JsonConvert.DeserializeObject<LinkedList<Partido>>(File.ReadAllText("partido.json"));
            Partido p = null;
            foreach (Partido i in part)
            {
                if (i.Nome == nome)
                    p = i;
            }
            return p;
        }
        public static LinkedList<Partido> RetornoPartido(LinkedList<int> arsenal)
        {
            LinkedList<Partido> p = new LinkedList<Partido>();
            LinkedList<Partido> deserializado = Cache.DeserializaPartido();

            foreach (int i in arsenal)
            {
                if (i >= 100)
                {
                    foreach (Partido g in deserializado)
                    {
                        if (i == g.Codigo)
                            p.Add(g);
                    }
                }
            }
            return p;
        }

        // Classe que apenas retorna uma lista com os Politicos
        public static LinkedList<Politico> RetornoPolitico(LinkedList<int> arsenal)
        {
            LinkedList<Politico> p = new LinkedList<Politico>();
            LinkedList<Politico> deserializado = Cache.DeserializaPolitico();

            foreach(int i in arsenal)
            {
                if(i < 100)
                {
                    foreach(Politico g in deserializado)
                    {
                        if (i == g.Codigo)
                            p.Add(g);
                    }
                }
            }
            return p;
        }

        // Metodo que verifica se tem alguma figurinha colada
        public static bool Colada(int codigo)
        {
            Usuario u = DeserializaLog();
            bool indice = false;
            if(u.FigurinhasColadas != null)
            {
                foreach(int i in u.FigurinhasColadas)
                {
                    if (i == codigo)
                    {
                        indice = true;
                        break;
                    }
                    else
                        indice = false;
                }
            }
            else
            {
                indice = false;
            }
            return indice;
        }

        // Deserialização e Serialização do JSON Politico
        public static LinkedList<Politico> DeserializaPolitico()
        {
                if (File.Exists("politico.json"))
                {
                    LinkedList<Politico> p = new LinkedList<Politico>();
                    p = JsonConvert.DeserializeObject<LinkedList<Politico>>(File.ReadAllText("politico.json"));
                    return p;
                }
                else
                {
                    throw new Exception("Não existe nada para ser lido."); 
                }
        }
        public static void SerializaPolitico(int cod, string nome, string cargo, double milhoes, int chapa, string img, string partido)
        {
            LinkedList<Politico> r = DeserializaPolitico();
            r.AddLast(new Politico() {
                Codigo = cod,
                Nome = nome,
                Cargo = cargo,
                MilhoesLavados = milhoes,
                NumeroChapa = chapa,
                Imagem = img,
                Partido = RetornoPartido(partido)
            });
            var politicoJson = JsonConvert.SerializeObject(r, Formatting.Indented);
            File.WriteAllText("politico.json", politicoJson);
        }

        // Deserialização e Serialização do JSON Partido
        public static LinkedList<Partido> DeserializaPartido()
        {
            if (File.Exists("partido.json"))
            {
                LinkedList<Partido> p = new LinkedList<Partido>();
                p = JsonConvert.DeserializeObject<LinkedList<Partido>>(File.ReadAllText("partido.json"));
                return p;
            }
            else
            {
                throw new Exception("Não existe nada para ser lido.");
            }
        }
        public static string SerializaPartido(int cod, string nome, string juiz, int chapa, string sigla, string financiador, string img)
        {
            try
            {

                string partidoJson = "";
                if (File.Exists("partido.json"))
                {
                    LinkedList<Partido> r = DeserializaPartido();
                    r.AddLast(new Partido()
                    {
                        Codigo = cod,
                        Nome = nome,
                        JuizConfianca = juiz,
                        NumeroChapa = chapa,
                        Sigla = sigla,
                        Financiador = financiador,
                        Imagem = img
                    });
                    partidoJson = JsonConvert.SerializeObject(r, Formatting.Indented);
                    File.WriteAllText("partido.json", partidoJson);
                }
                else
                {
                    File.WriteAllText("partido.json", partidoJson);
                }
                return "Inserido com sucesso!";
            }
            catch (Exception e)
            {
                return "Não foi possível inserir. Erro: " + e.Message;
            }
            
        }

        // Deserialização e Serialização do JSON usuário
        public static string SerializaUsuario(string nome, string senha, string login, LinkedList<int> arsenal, int coladas, string data)
        {
            try
            {
                if (nome == "" || senha == "" || login == "")
                    return "Você fez algo de errado, ou deixou algum campo em branco. Tente novamente.";

                string usuariosJson = "";
                if (File.Exists("usuarios.json"))
                {
                    LinkedList<Usuario> u = DeserializaUsuario();
                    u.AddLast(new Usuario()
                    {
                        Nome = nome,
                        Login = login,
                        Senha = senha,
                        Arsenal = arsenal,
                        UltimaData = data
                    });
                    usuariosJson = JsonConvert.SerializeObject(u, Formatting.Indented);
                    File.WriteAllText("usuarios.json", usuariosJson);
                }
                else
                {
                    File.WriteAllText("usuarios.json", usuariosJson);
                }
                return "Inserido com sucesso!";
            }
            catch (Exception e)
            {
                return "Não foi possível inserir. Erro: " + e.Message;
            }
            
        }
        public static void SerializaUsuario(LinkedList<Usuario> u)
        {
             var usuarion = JsonConvert.SerializeObject(u, Formatting.Indented);
             File.WriteAllText("usuarios.json", usuarion);

        }
        // Sobrecarga do método para outra aplicação
        public static LinkedList<Usuario> DeserializaUsuario()
        {
            if (File.Exists("usuarios.json"))
            {
                LinkedList<Usuario> p = new LinkedList<Usuario>();
                p = JsonConvert.DeserializeObject<LinkedList<Usuario>>(File.ReadAllText("usuarios.json"));
                return p;
            }
            else
            {
                throw new Exception("Não existe nada para ser lido.");
            }
        }

        // Deserialização e Serialização do JSON Log 
        // Log é o que fica rodando de fundo enquanto um usuário está logado, ela só guarda o atual.
        public static Usuario DeserializaLog()
        {
            if (File.Exists("logs.json"))
            {
                Usuario p = new Usuario();
                p = JsonConvert.DeserializeObject<Usuario>(File.ReadAllText("logs.json"));
                return p;
            }
            else
            {
                throw new Exception("Não existe nada para ser lido.");
            }
        }
        public static string SerializaLog(Usuario u)
        {
                string usuariosJson = "";
                if (File.Exists("logs.json"))
                {
                    usuariosJson = JsonConvert.SerializeObject(u, Formatting.Indented);
                    File.WriteAllText("logs.json", usuariosJson);
                }
                else
                {
                    File.WriteAllText("logs.json", usuariosJson);
                }
                return "Inserido com sucesso!";
        }

        // Deserialização e Serialização do JSON Perguntas
        // Para cadastro de perguntas, e leitura da mesma
        public static string SerializaPergunta(LinkedList<Perguntas> p)
        {
            string perguntasJson = "";
            if (File.Exists("perguntas.json"))
            {
                perguntasJson = JsonConvert.SerializeObject(p, Formatting.Indented);
                File.WriteAllText("perguntas.json", perguntasJson);
            }
            else
            {
                File.WriteAllText("perguntas.json", perguntasJson);
            }
            return "Inserido com sucesso!";
        }
        public static LinkedList<Perguntas> DeserializaPerguntas()
        {
            if (File.Exists("usuarios.json"))
            {
                LinkedList<Perguntas> p = new LinkedList<Perguntas>();
                p = JsonConvert.DeserializeObject<LinkedList<Perguntas>>(File.ReadAllText("perguntas.json"));
                return p;
            }
            else
            {
                throw new Exception("Não existe nada para ser lido.");
            }
        }


    }
}
