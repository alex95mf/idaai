﻿using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using CsvHelper.Configuration.Attributes;
using Newtonsoft.Json;

namespace IDAAI_APP.Models.Operations.Request
{
    public class EstudianteRegistrarRequest
    {
        [Required]
        [StringLength(maximumLength: 100)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string Apellidos { get; set; }

        [Required]
        [StringLength(maximumLength: 10)]
        public string Matricula { get; set; }

        [EmailAddress]
        [StringLength(maximumLength: 50)]
        public string Email { get; set; }

        [StringLength(maximumLength: 100)]
        public string Direccion { get; set; }

        [StringLength(maximumLength: 100)]
        public string Carrera { get; set; }

        [Required]
        [StringLength(maximumLength: 50)]
        public string Modulo { get; set; }

        [Required]
        [StringLength(maximumLength: 25)]
        public string Usuario { get; set; }
    }

    public class EstudianteGrupoRegistrarRequest
    {
        [Required]
        [StringLength(maximumLength: 50)]
        public string Modulo { get; set; }

        [Required]
        public IFormFileCollection Archivo { get; set; }

        [Required]
        [StringLength(maximumLength: 25)]
        public string Usuario { get; set; }
    }

    public class EstudianteGrupoRequest
    {
        [Required]
        [StringLength(maximumLength: 50)]
        public string Modulo { get; set; }

        [Required]
        public List<EstudianteRegistrarRequest> Estudiantes { get; set; }

        [Required]
        [StringLength(maximumLength: 25)]
        public string Usuario { get; set; }
    }

    public class GrupoEstudiante
    {
        [CsvHelper.Configuration.Attributes.Optional]
        [Name("Student")]
        public string Student { get; set; }
        //[Optional]
        //public string ID { get; set; }
        [CsvHelper.Configuration.Attributes.Optional]
        [Name("SIS User ID")]
        public string SISUserID { get; set; }
        [CsvHelper.Configuration.Attributes.Optional]
        [Name("SIS Login ID")]
        public string SISLoginID { get; set; }
        //[Optional]
        //public string Section { get; set; }
        //    [Optional]
        //    public string LP3 { get; set; }
        //    [Optional]
        //    public string LP5 { get; set; }
        //    [Optional]
        //    public string LP6 { get; set; }
        //    [Optional]
        //    public string LP8 { get; set; }
        //    [Optional]
        //    public string LP9 { get; set; }
        //    [Optional]
        //    public string P3 { get; set; }
        //    [Optional]
        //    public string P7 { get; set; }
        //    [Optional]
        //    public string P4 { get; set; }
        //    [Optional]
        //    public string P5 { get; set; }
        //    [Optional]
        //    public string P6 { get; set; }
        //    [Optional]
        //    public string P8 { get; set; }
        //    [Optional]
        //    public string P9 { get; set; }
        //    [Optional]
        //    public string D2 { get; set; }
        //    [Optional]
        //    public string D3 { get; set; }
        //    [Optional]
        //    public string D4 { get; set; }
        //    [Optional]
        //    public string D5 { get; set; }
        //    [Optional]
        //    public string D6 { get; set; }
        //    [Optional]
        //    public string D7 { get; set; }
        //    [Optional]
        //    public string D8 { get; set; }
        //    [Optional]
        //    public string D9 { get; set; }
        //    [Optional]
        //    public string PP4 { get; set; }
        //    [Optional]
        //    public string PP6 { get; set; }
        //    [Optional]
        //    public string InformeAvanceProyecto { get; set; }
        //    [Optional]
        //    public string InformeProyectoFinal { get; set; }
        //    [Optional]
        //    public string VideoProyecto { get; set; }
        //    [Optional]
        //    public string LeccionesPuntaje { get; set; }
        //    [Optional]
        //    public string LeccionesPuntajeSinPublicar { get; set; }
        //    [Optional]
        //    public string LeccionesPuntajeFinal { get; set; }
        //    [Optional]
        //    public string LeccionesPuntajeFinalSinPublicar { get; set; }
        //    [Optional]
        //    public string PracticasPuntaje { get; set; }
        //    [Optional]
        //    public string PracticasPuntajeSinPublicar { get; set; }
        //    [Optional]
        //    public string PracticasPuntajeFinal { get; set; }
        //    [Optional]
        //    public string PracticasPuntajeFinalSinPublicar { get; set; }
        //    [Optional]
        //    public string DesafiosPuntaje { get; set; }
        //    [Optional]
        //    public string DesafiosPuntajeSinPublicar { get; set; }
        //    [Optional]
        //    public string DesafiosPuntajeFinal { get; set; }
        //    [Optional]
        //    public string DesafiosPuntajeFinalSinPublicar { get; set; }
        //    [Optional]
        //    public string PrePracticasPuntaje { get; set; }
        //    [Optional]
        //    public string PrePracticasPuntajeSinPublicar { get; set; }
        //    [Optional]
        //    public string PrePracticasPuntajeFinal { get; set; }
        //    [Optional]
        //    public string PrePracticasPuntajeFinalSinPublicar { get; set; }
        //    [Optional]
        //    public string EntregablesProyectoPuntaje { get; set; }
        //    [Optional]
        //    public string EntregablesProyectoPuntajeSinPublicar { get; set; }
        //    [Optional]
        //    public string EntregablesProyectoPuntajeFinal { get; set; }
        //    [Optional]
        //    public string EntregablesProyectoPuntajeFinalSinPublicar { get; set; }
        //    [Optional]
        //    public string ProyectoPuntaje { get; set; }
        //    [Optional]
        //    public string ProyectoPuntajeSinPublicar { get; set; }
        //    [Optional]
        //    public string ProyectoPuntajeFinal { get; set; }
        //    [Optional]
        //    public string ProyectoPuntajeFinalSinPublicar { get; set; }
        //    [Optional]
        //    public string Puntaje { get; set; }
        //    [Optional]
        //    public string PuntajeSinPublicar { get; set; }
        //    [Optional]
        //    public string PuntajeFinal { get; set; }
        //    [Optional]
        //    public string PuntajeFinalSinPublicar { get; set; }
    }

    public class SeleccionarModuloRequest
    {
        [Required]
        [StringLength(maximumLength: 50)]
        public string Modulo { get; set; }
    }

    public class EstudianteEditarRequest
    {
        [Required]
        public int Id { get; set; }

        [StringLength(maximumLength: 100)]
        public string Nombres { get; set; }

        [StringLength(maximumLength: 100)]
        public string Apellidos { get; set; }

        [StringLength(maximumLength: 10)]
        public string Matricula { get; set; }

        [EmailAddress]
        [StringLength(maximumLength: 50)]
        public string Email { get; set; }

        [StringLength(maximumLength: 100)]
        public string Direccion { get; set; }

        [StringLength(maximumLength: 100)]
        public string Carrera { get; set; }

        [StringLength(maximumLength: 50)]
        public string Modulo { get; set; }

        [Required]
        [StringLength(maximumLength: 25)]
        public string Usuario { get; set; }
    }
}
