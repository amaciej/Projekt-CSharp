/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     30.11.2018 15:52:06                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('AUTOKARY') and o.name = 'FK_AUTOKARY_KIEROWCA__KIEROWCY')
alter table AUTOKARY
   drop constraint FK_AUTOKARY_KIEROWCA__KIEROWCY
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('KURSY') and o.name = 'FK_KURSY_AUTOKAR W_AUTOKARY')
alter table KURSY
   drop constraint "FK_KURSY_AUTOKAR W_AUTOKARY"
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('KURSY') and o.name = 'FK_KURSY_TRASA W K_TRASY')
alter table KURSY
   drop constraint "FK_KURSY_TRASA W K_TRASY"
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ODCINEK') and o.name = 'FK_ODCINEK_KONIEC_MIEJSCOW')
alter table ODCINEK
   drop constraint FK_ODCINEK_KONIEC_MIEJSCOW
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ODCINEK') and o.name = 'FK_ODCINEK_START_MIEJSCOW')
alter table ODCINEK
   drop constraint FK_ODCINEK_START_MIEJSCOW
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ODCINEK_TRASY') and o.name = 'FK_ODCINEK__ODCINEK_T_ODCINEK')
alter table ODCINEK_TRASY
   drop constraint FK_ODCINEK__ODCINEK_T_ODCINEK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ODCINEK_TRASY') and o.name = 'FK_ODCINEK__ODCINEK_T_TRASY')
alter table ODCINEK_TRASY
   drop constraint FK_ODCINEK__ODCINEK_T_TRASY
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PASA¯EROWIE_KURSY') and o.name = 'FK_PASA¯ERO_KURS_PASA_PASA¯ERO')
alter table PASA¯EROWIE_KURSY
   drop constraint FK_PASA¯ERO_KURS_PASA_PASA¯ERO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PASA¯EROWIE_KURSY') and o.name = 'FK_PASA¯ERO_PASA¯EROW_KURSY')
alter table PASA¯EROWIE_KURSY
   drop constraint FK_PASA¯ERO_PASA¯EROW_KURSY
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('U¯YTKOWNICY') and o.name = 'FK_U¯YTKOWN_FUNCKJA U_UPRAWNIE')
alter table U¯YTKOWNICY
   drop constraint "FK_U¯YTKOWN_FUNCKJA U_UPRAWNIE"
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('AUTOKARY')
            and   name  = 'Kierowca_autobusu_FK'
            and   indid > 0
            and   indid < 255)
   drop index AUTOKARY.Kierowca_autobusu_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('AUTOKARY')
            and   type = 'U')
   drop table AUTOKARY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KIEROWCY')
            and   type = 'U')
   drop table KIEROWCY
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('KURSY')
            and   name  = 'Autokar w kursie_FK'
            and   indid > 0
            and   indid < 255)
   drop index KURSY."Autokar w kursie_FK"
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('KURSY')
            and   name  = 'Trasa w kursie_FK'
            and   indid > 0
            and   indid < 255)
   drop index KURSY."Trasa w kursie_FK"
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KURSY')
            and   type = 'U')
   drop table KURSY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MIEJSCOWOŒCI')
            and   type = 'U')
   drop table MIEJSCOWOŒCI
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ODCINEK')
            and   name  = 'Koniec_FK'
            and   indid > 0
            and   indid < 255)
   drop index ODCINEK.Koniec_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ODCINEK')
            and   name  = 'Start_FK'
            and   indid > 0
            and   indid < 255)
   drop index ODCINEK.Start_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ODCINEK')
            and   type = 'U')
   drop table ODCINEK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ODCINEK_TRASY')
            and   name  = 'ODCINEK_TRASY2_FK'
            and   indid > 0
            and   indid < 255)
   drop index ODCINEK_TRASY.ODCINEK_TRASY2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ODCINEK_TRASY')
            and   name  = 'ODCINEK_TRASY_FK'
            and   indid > 0
            and   indid < 255)
   drop index ODCINEK_TRASY.ODCINEK_TRASY_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ODCINEK_TRASY')
            and   type = 'U')
   drop table ODCINEK_TRASY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PASA¯EROWIE')
            and   type = 'U')
   drop table PASA¯EROWIE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PASA¯EROWIE_KURSY')
            and   name  = 'Pasa¿erowie w kursie_FK'
            and   indid > 0
            and   indid < 255)
   drop index PASA¯EROWIE_KURSY."Pasa¿erowie w kursie_FK"
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PASA¯EROWIE_KURSY')
            and   name  = 'Kurs_pasa¿era_FK'
            and   indid > 0
            and   indid < 255)
   drop index PASA¯EROWIE_KURSY.Kurs_pasa¿era_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PASA¯EROWIE_KURSY')
            and   type = 'U')
   drop table PASA¯EROWIE_KURSY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TRASY')
            and   type = 'U')
   drop table TRASY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('UPRAWNIENIA')
            and   type = 'U')
   drop table UPRAWNIENIA
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('U¯YTKOWNICY')
            and   name  = 'Funckja u¿ytkowników_FK'
            and   indid > 0
            and   indid < 255)
   drop index U¯YTKOWNICY."Funckja u¿ytkowników_FK"
go

if exists (select 1
            from  sysobjects
           where  id = object_id('U¯YTKOWNICY')
            and   type = 'U')
   drop table U¯YTKOWNICY
go

/*==============================================================*/
/* Table: AUTOKARY                                              */
/*==============================================================*/
create table AUTOKARY (
   Id_Autokaru          int                  not null,
   Id_Kierowcy          int                  null,
   Nr_Rejstracyjny      varchar(7)           null,
   Iiloœæ_Miejsc        int                  null,
   Marka                varchar(25)          null,
   Model                varchar(20)          null,
   Rocznik              int                  null,
   constraint PK_AUTOKARY primary key nonclustered (Id_Autokaru)
)
go

/*==============================================================*/
/* Index: Kierowca_autobusu_FK                                  */
/*==============================================================*/
create index Kierowca_autobusu_FK on AUTOKARY (
Id_Kierowcy ASC
)
go

/*==============================================================*/
/* Table: KIEROWCY                                              */
/*==============================================================*/
create table KIEROWCY (
   Id_Kierowcy          int                  not null,
   Imiê                 varchar(50)          null,
   Nazwisko             varchar(50)          null,
   PESEL                numeric(11)          null,
   constraint PK_KIEROWCY primary key nonclustered (Id_Kierowcy)
)
go

/*==============================================================*/
/* Table: KURSY                                                 */
/*==============================================================*/
create table KURSY (
   Id_Kursy             int                  not null,
   Id_Trasy             int                  null,
   Id_Autokaru          int                  null,
   Dni                  varchar(50)          null,
   Godz_Pocz¹tek        datetime             null,
   Godz_Koniec          datetime             null,
   Iloœæ_Pasa¿erów      int                  null,
   constraint PK_KURSY primary key nonclustered (Id_Kursy)
)
go

/*==============================================================*/
/* Index: "Trasa w kursie_FK"                                   */
/*==============================================================*/
create index "Trasa w kursie_FK" on KURSY (
Id_Trasy ASC
)
go

/*==============================================================*/
/* Index: "Autokar w kursie_FK"                                 */
/*==============================================================*/
create index "Autokar w kursie_FK" on KURSY (
Id_Autokaru ASC
)
go

/*==============================================================*/
/* Table: MIEJSCOWOŒCI                                          */
/*==============================================================*/
create table MIEJSCOWOŒCI (
   Id_Miejscowoœci      int                  not null,
   M_Nazwa              varchar(50)          null,
   constraint PK_MIEJSCOWOŒCI primary key nonclustered (Id_Miejscowoœci)
)
go

/*==============================================================*/
/* Table: ODCINEK                                               */
/*==============================================================*/
create table ODCINEK (
   Id_Odcinek           int                  not null,
   Id_Miejscowoœci_S    int                  null,
   Id_Miejscowoœci_K    int                  null,
   D³ugoœæ              varchar(7)           null,
   Godz_Pocz¹tek        datetime             null,
   Godz_Koniec          datetime             null,
   Cena_Biletu          money                null,
   constraint PK_ODCINEK primary key nonclustered (Id_Odcinek)
)
go

/*==============================================================*/
/* Index: Start_FK                                              */
/*==============================================================*/
create index Start_FK on ODCINEK (
Id_Miejscowoœci_K ASC
)
go

/*==============================================================*/
/* Index: Koniec_FK                                             */
/*==============================================================*/
create index Koniec_FK on ODCINEK (
Id_Miejscowoœci_S ASC
)
go

/*==============================================================*/
/* Table: ODCINEK_TRASY                                         */
/*==============================================================*/
create table ODCINEK_TRASY (
   Id_Odcinek           int                  not null,
   Id_Trasy             int                  not null,
   Kolejnoœæ            int                  null,
   constraint PK_ODCINEK_TRASY primary key (Id_Odcinek, Id_Trasy)
)
go

/*==============================================================*/
/* Index: ODCINEK_TRASY_FK                                      */
/*==============================================================*/
create index ODCINEK_TRASY_FK on ODCINEK_TRASY (
Id_Odcinek ASC
)
go

/*==============================================================*/
/* Index: ODCINEK_TRASY2_FK                                     */
/*==============================================================*/
create index ODCINEK_TRASY2_FK on ODCINEK_TRASY (
Id_Trasy ASC
)
go

/*==============================================================*/
/* Table: PASA¯EROWIE                                           */
/*==============================================================*/
create table PASA¯EROWIE (
   Id_Pasa¿er           int                  not null,
   Imiê                 varchar(50)          null,
   Nazwisko             varchar(50)          null,
   constraint PK_PASA¯EROWIE primary key nonclustered (Id_Pasa¿er)
)
go

/*==============================================================*/
/* Table: PASA¯EROWIE_KURSY                                     */
/*==============================================================*/
create table PASA¯EROWIE_KURSY (
   Id_PasKurs           int                  not null,
   Id_Kursy             int                  null,
   Id_Pasa¿er           int                  null,
   constraint PK_PASA¯EROWIE_KURSY primary key nonclustered (Id_PasKurs)
)
go

/*==============================================================*/
/* Index: Kurs_pasa¿era_FK                                      */
/*==============================================================*/
create index Kurs_pasa¿era_FK on PASA¯EROWIE_KURSY (
Id_Pasa¿er ASC
)
go

/*==============================================================*/
/* Index: "Pasa¿erowie w kursie_FK"                             */
/*==============================================================*/
create index "Pasa¿erowie w kursie_FK" on PASA¯EROWIE_KURSY (
Id_Kursy ASC
)
go

/*==============================================================*/
/* Table: TRASY                                                 */
/*==============================================================*/
create table TRASY (
   Id_Trasy             int                  not null,
   U_Nazwa              varchar(50)          null,
   Czas_Trasy           int                  null,
   constraint PK_TRASY primary key nonclustered (Id_Trasy)
)
go

/*==============================================================*/
/* Table: UPRAWNIENIA                                           */
/*==============================================================*/
create table UPRAWNIENIA (
   Id_Upr               int                  not null,
   U_Nazwa              varchar(50)          null,
   constraint PK_UPRAWNIENIA primary key nonclustered (Id_Upr)
)
go

/*==============================================================*/
/* Table: U¯YTKOWNICY                                           */
/*==============================================================*/
create table U¯YTKOWNICY (
   Id_U¿yt              int                  not null,
   Id_Upr               int                  not null,
   Login                varchar(50)          null,
   Has³o                varchar(50)          null,
   constraint PK_U¯YTKOWNICY primary key nonclustered (Id_U¿yt)
)
go

/*==============================================================*/
/* Index: "Funckja u¿ytkowników_FK"                             */
/*==============================================================*/
create index "Funckja u¿ytkowników_FK" on U¯YTKOWNICY (
Id_Upr ASC
)
go

alter table AUTOKARY
   add constraint FK_AUTOKARY_KIEROWCA__KIEROWCY foreign key (Id_Kierowcy)
      references KIEROWCY (Id_Kierowcy)
go

alter table KURSY
   add constraint "FK_KURSY_AUTOKAR W_AUTOKARY" foreign key (Id_Autokaru)
      references AUTOKARY (Id_Autokaru)
go

alter table KURSY
   add constraint "FK_KURSY_TRASA W K_TRASY" foreign key (Id_Trasy)
      references TRASY (Id_Trasy)
go

alter table ODCINEK
   add constraint FK_ODCINEK_KONIEC_MIEJSCOW foreign key (Id_Miejscowoœci_S)
      references MIEJSCOWOŒCI (Id_Miejscowoœci)
go

alter table ODCINEK
   add constraint FK_ODCINEK_START_MIEJSCOW foreign key (Id_Miejscowoœci_K)
      references MIEJSCOWOŒCI (Id_Miejscowoœci)
go

alter table ODCINEK_TRASY
   add constraint FK_ODCINEK__ODCINEK_T_ODCINEK foreign key (Id_Odcinek)
      references ODCINEK (Id_Odcinek)
go

alter table ODCINEK_TRASY
   add constraint FK_ODCINEK__ODCINEK_T_TRASY foreign key (Id_Trasy)
      references TRASY (Id_Trasy)
go

alter table PASA¯EROWIE_KURSY
   add constraint FK_PASA¯ERO_KURS_PASA_PASA¯ERO foreign key (Id_Pasa¿er)
      references PASA¯EROWIE (Id_Pasa¿er)
go

alter table PASA¯EROWIE_KURSY
   add constraint FK_PASA¯ERO_PASA¯EROW_KURSY foreign key (Id_Kursy)
      references KURSY (Id_Kursy)
go

alter table U¯YTKOWNICY
   add constraint "FK_U¯YTKOWN_FUNCKJA U_UPRAWNIE" foreign key (Id_Upr)
      references UPRAWNIENIA (Id_Upr)
go

