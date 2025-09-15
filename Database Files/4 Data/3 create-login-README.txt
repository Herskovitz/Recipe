script to create login and user is excluded from this repo.
Create a file called create-login.sql (this files is ignored by git ignore in this repo)
Add the following script to that file

--Important create login in Master!
--use MASTER
create login [loginname] with password = [password]

--Important switch to target DB (- RecipeDB)
create user [username] from login [loginname]