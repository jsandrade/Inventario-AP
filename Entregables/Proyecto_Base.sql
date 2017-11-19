/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     8/11/2017 16:27:21                           */
/*==============================================================*/


drop table if exists PEADM_ADMIN;

drop table if exists PECLI_CLIENTE;

drop table if exists PELOG_LOGIN;

drop table if exists PEPRO_PRODUC;

drop table if exists PEVEN_VENTA;

drop table if exists PR_PEVEN_VENTA_PECLI_CLIENTE;

drop table if exists PR_PEVEN_VENTA_PEPRO_PRODUC;



/*==============================================================*/
/* Table: PEADM_ADMIN                                           */
/*==============================================================*/
create table PEADM_ADMIN
(
   PEADM_CODIGO         int not null AUTO_INCREMENT,
   PELOG_ID             int,
   PEADM_CEDULA         varchar(10) not null,
   PEADM_NOMBRE         varchar(50) not null,
   PEADM_APELLIDO       varchar(50) not null,
   primary key (PEADM_CODIGO)
);

alter table PEADM_ADMIN comment 'ENTIDAD CREADA PARA REALIZAR EL CRUD DE PERSONAS QUE VAN A U';

/*==============================================================*/
/* Table: PECLI_CLIENTE                                         */
/*==============================================================*/
create table PECLI_CLIENTE
(
   PECLI_CODIGO         int not null AUTO_INCREMENT,
   PECLI_CEDULA         varchar(10) not null,
   PECLI_APELLIDOPATERNO varchar(30) not null,
   PECLI_APELLIDOMATERNO varchar(30),
   PECLI_NOMBRES        varchar(60) not null,
   PECLI_FIJO           numeric(9,0),
   PECLI_CELULAR        numeric(10,0),
   PECLI_DIRECCION      varchar(254) not null,
   PECLI_CORREO         varchar(250),
   primary key (PECLI_CODIGO)
);

alter table PECLI_CLIENTE comment 'ENTIDAD CREADA PARA REALIZAR EL CRUD DE LOS CLIENTES';

/*==============================================================*/
/* Table: PELOG_LOGIN                                           */
/*==============================================================*/
create table PELOG_LOGIN
(
   PELOG_ID             int not null AUTO_INCREMENT,
   PELOG_USER           varchar(30) not null,
   PELOG_PASSWORD       varchar(30) not null,
   primary key (PELOG_ID)
);

alter table PELOG_LOGIN comment 'ENTIDAD CREADA PARA REALIZAR EL CRUD DE LOGIN AL PROGRAMA';

/*==============================================================*/
/* Table: PEPRO_PRODUC                                          */
/*==============================================================*/
create table PEPRO_PRODUC
(
   PEPRO_CODIGO         int not null AUTO_INCREMENT, 
   PEPRO_NOMBRE         varchar(50) not null,
   PEPRO_SERIE          varchar(50),
   PEPRO_MODELO         varchar(50),
   PEPRO_MARCA          varchar(50),
   PEPRO_PRECIO         numeric(8,2) not null,
   PEPRO_DESCRIPCION    varchar(254),
   PEPRO_STOCK          varchar(4) not null,
   primary key (PEPRO_CODIGO)
);

alter table PEPRO_PRODUC comment 'ENTIDAD CREADA PARA REALIZAR EL CRUD DE PRODUCTOS';

/*==============================================================*/
/* Table: PEVEN_VENTA                                           */
/*==============================================================*/
create table PEVEN_VENTA
(
   PEVEN_CODIGO         int not null AUTO_INCREMENT,
   PEVEN_NUMVENTA       varchar(30) not null,
   PEVEN_NUMFIC         varchar(30),
   PEVEN_PRECIOT        numeric(8,2) not null,
   PEVEN_FECHA          date not null,
   primary key (PEVEN_CODIGO)
);

alter table PEVEN_VENTA comment 'ENTIDAD CREADA PARA REALIZAR EL CRUD DE VENTAS';

/*==============================================================*/
/* Table: PR_PEVEN_VENTA_PECLI_CLIENTE                          */
/*==============================================================*/
create table PR_PEVEN_VENTA_PECLI_CLIENTE
(
   PECLI_CODIGO         int not null  AUTO_INCREMENT,
   PEVEN_CODIGO         int not null AUTO_INCREMENT,
   primary key (PECLI_CODIGO, PEVEN_CODIGO)
);

alter table PR_PEVEN_VENTA_PECLI_CLIENTE comment 'RELACION ENTRE LAS ENTIDADES VENTA Y CLIENTE
';

/*==============================================================*/
/* Table: PR_PEVEN_VENTA_PEPRO_PRODUC                           */
/*==============================================================*/
create table PR_PEVEN_VENTA_PEPRO_PRODUC
(
   PEPRO_CODIGO         int not null AUTO_INCREMENT,
   PEVEN_CODIGO         int not null AUTO_INCREMENT,
   primary key (PEPRO_CODIGO, PEVEN_CODIGO)
);

alter table PR_PEVEN_VENTA_PEPRO_PRODUC comment 'RELACION ENTRE VENTA Y PRODUCTO
';

alter table PEADM_ADMIN add constraint FK_PR_PELOG_LOGIN_PEADMIN foreign key (PELOG_ID)
      references PELOG_LOGIN (PELOG_ID) on delete restrict on update restrict;

alter table PR_PEVEN_VENTA_PECLI_CLIENTE add constraint FK_PR_PEVEN_VENTA_PECLI_CLIENTE foreign key (PECLI_CODIGO)
      references PECLI_CLIENTE (PECLI_CODIGO) on delete restrict on update restrict;

alter table PR_PEVEN_VENTA_PECLI_CLIENTE add constraint FK_PR_PEVEN_VENTA_PECLI_CLIENTE2 foreign key (PEVEN_CODIGO)
      references PEVEN_VENTA (PEVEN_CODIGO) on delete restrict on update restrict;

alter table PR_PEVEN_VENTA_PEPRO_PRODUC add constraint FK_PR_PEVEN_VENTA_PEPRO_PRODUC foreign key (PEPRO_CODIGO)
      references PEPRO_PRODUC (PEPRO_CODIGO) on delete restrict on update restrict;

alter table PR_PEVEN_VENTA_PEPRO_PRODUC add constraint FK_PR_PEVEN_VENTA_PEPRO_PRODUC2 foreign key (PEVEN_CODIGO)
      references PEVEN_VENTA (PEVEN_CODIGO) on delete restrict on update restrict;

