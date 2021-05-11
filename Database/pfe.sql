CREATE DATABASE gestion_conge
use gestion_conge
CREATE TABLE employeee(
                    id int IDENTITY(1,1) UNIQUE  ,
                    loginn varchar(50) UNIQUE   ,
                    nom varchar(50) ,
                    prenom varchar(50) ,
                    passe varchar(156)  ,    
                    en_congé int NOT NULL DEFAULT 0 CHECK (en_congé IN (0, 1)),
                    solde int DEFAULT 30 ,
                    PRIMARY KEY(id,loginn)
                    )

CREATE TABLE conge (
                    id_en_conge int  identity(1,1) UNIQUE ,
                    login_emp VARCHAR(50)FOREIGN KEY REFERENCES employeee(loginn) on update cascade on delete cascade,
                    date_debut DATE,
                    date_fin DATE  ,
                    nbr_de_jour FLOAT,
                    date_retour DATE ,
                    typee varchar(35),
                    demandé int NOT NULL DEFAULT 1 CHECK (demandé IN (0, 1)),
                    accepté int NOT NULL DEFAULT 0 CHECK (accepté IN (0, 1)),
        
                    PRIMARY KEY(id_en_conge))
CREATE TABLE conge_refusé (
                    id_refusé int IDENTITY (1,1) UNIQUE ,
                    login_emp VARCHAR(50) NOT NULL,
                    date_debut DATE,
                    date_fin DATE ,
                    nbr_de_jour FLOAT,
                    date_retour DATE ,
                    typee varchar(35),
)
CREATE TABLE conge_accepté (
                    id_accepté int IDENTITY (1,1) UNIQUE ,
                    login_emp VARCHAR(50) NOT NULL,
                    date_debut DATE,
                    date_fin DATE ,
                    nbr_de_jour FLOAT,
                    date_retour DATE ,
                    typee varchar(35),
)

    

DROP TABLE conge
drop table employeee
DROP TABLE conge_refusé

alter TABLE employeee ADD CONSTRAINT chk_pass_len CHECK (DATALENGTH(passe)>=8)


insert into employeee(loginn,nom,prenom,passe) values ('lzs_jinxin','Touihri','Adam','password')

SELECT * from employeee ORDER by id
SELECT * from conge order by id_en_conge
SELECT * FROM conge_refusé
SELECT * FROM conge_accepté




DELETE FROM conge WHERE id_en_conge = 1 

truncate table conge
truncate table conge_refusé
truncate table conge_accepté

UPDATE employeee SET solde = 30
select id_en_coge,login_client,nom,prenom,date_debut,date_fin,nbr_de_jour,date_retour from employeee e, conge c where loginn=login_client order by id_en_coge


ALTER TABLE conge add CONSTRAINT chk_date check(date_debut <GETDATE()) 