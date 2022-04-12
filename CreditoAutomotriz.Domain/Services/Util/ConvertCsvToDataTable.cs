using CreditoAutomotriz.Entities;
using CreditoAutomotriz.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoAutomotriz.Domain.Services.Util
{
    public class ConvertCsvToDataTable
    {
        public static List<UserCreateModel> igualarData(List<clientesEntity> lc)
        {
            List<UserCreateModel> users = new List<UserCreateModel>();
            lc.ForEach(data =>
            {
                UserCreateModel user = new UserCreateModel();
                try
                {
                    user.identificacion = data.identificacion;
                    user.nombres = data.nombres;
                    user.edad = int.Parse(data.edad);
                    user.fechaNacimiento = DateTime.Parse(data.fechaNacimiento);
                    user.apellidos = data.apellidos;
                    user.direccion = data.direccion;
                    user.telefono = data.telefono;
                    user.estadoCivil = data.estadoCivil;
                    if (user.estadoCivil.Equals("CASADO"))
                    {
                        user.identificacionConyugue = data.identificacionConyugue;
                        user.nombreConyugue = data.nombreConyugue;
                    }
                    user.sujetoCredito = data.sujetoCredito;
                }
                catch (Exception ex)
                {
                    throw new SyntaxErrorException();
                }
                users.Add(user);
            });

            return users;

        }
        public static List<clientesEntity> leerData(string filePath)
        {
            List<clientesEntity> listaClientes = new List<clientesEntity>();
            var pp = File.ReadAllLines(filePath);
            try
            {
                listaClientes = (from p in pp
                                 let parts = p.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                 select new clientesEntity
                                 {
                                     identificacion = parts[0],
                                     nombres = parts[1],
                                     edad = parts[2],
                                     fechaNacimiento = parts[3],
                                     apellidos = parts[4],
                                     direccion = parts[5],
                                     telefono = parts[6],
                                     estadoCivil = parts[7],
                                     identificacionConyugue = parts[8],
                                     nombreConyugue = parts[9],
                                     sujetoCredito = parts[10]
                                 }).ToList();
            }
            catch (Exception ex)
            {

            }
            //elimina la cabecera
            listaClientes.RemoveAt(0);
            return listaClientes;
        }

        public static List<MarcasEntity> TransformarDataMarca(string filePath)
        {
            List<MarcasEntity> listaMarcas = new List<MarcasEntity>();
            var pp = File.ReadAllLines(filePath);
            try
            {
                listaMarcas = (from p in pp
                               let parts = p.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                               select new MarcasEntity
                               {
                                   descripcion = parts[0],
                                   estado = parts[1]

                               }).ToList();
            }
            catch (Exception ex)
            {

            }
            //elimina la cabecera
            listaMarcas.RemoveAt(0);
            return listaMarcas;
        }
        public static List<EjecutivosEntity> TransformarDataEjecutivo(string filePath)
        {
            List<EjecutivosEntity> listaEjecutivos = new List<EjecutivosEntity>();
            var pp = File.ReadAllLines(filePath);
            try
            {
                listaEjecutivos = (from p in pp
                                   let parts = p.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                   select new EjecutivosEntity
                                   {
                                       Nombres = parts[0],
                                       Apellidos = parts[1],
                                       Direccion = parts[2],
                                       Telefono = parts[3],
                                       Celular = parts[4],
                                       idPatio = parts[5],
                                       edad = parts[6],
                                       identificacion = parts[7]
                                   }).ToList();
            }
            catch (Exception ex)
            {

            }
            //elimina la cabecera
            listaEjecutivos.RemoveAt(0);
            return listaEjecutivos;
        }
    }
}
