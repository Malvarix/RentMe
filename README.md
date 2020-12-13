<h2>RentMeApp - Preview</h2>
<img src = https://user-images.githubusercontent.com/55942075/102016661-b0626c00-3d6a-11eb-9226-af9cad93ba6c.png>
<h2>*Annotations*</h2>
<ul><b>
  <li>Connection string to DB is located in '..\Server\WebAPI\BikesAPI\appsettings.json'</li>
  <li>If you wanna play with migrations please edit connection string in '..\Server\Infrastructure\Persistence\Contexts\BikesDbContext.cs' in default constructor</li>
</ul></b>
<h2>Git instructions</h2>
<ul><b>
  <li>[fix]: Fix description</li>
  <li>[trans]: Description</br>*Annotation for [trans] - is Transitional/Intermediate/Unable to work right now</li>
  <li>[doc]: Description</br>*Annotation for [doc] - README.md etc. files</li>
  <li>[build]: Build description</br>*Annotation for [build] - for ready builds</li>
</ul></b>
<h2>Installation tutorial</h2>
<h3>Client</h3>
<ul><b>
  <li>npm i</li>
  <li>ng s</li>
</ul></b>
<h3>Server</h3>
<ul><b>
  <li>Run with Kestrel server</li>
</ul></b>
<h2>Tech. task</h2>
<p>SPA must have a <b>form for adding bikes</b> which must <b>contains of</b> fields:</p>
<ul><b>
  <li>Title - text field</li>
  <li>Type (Road / Mountain) - drop down list</li>
  <li>Rent price - number field</li>
</ul></b>
<p>Under form for adding bikes must show up <b>two bike lists</b>: <b>"Available bikes"</b> and <b>"Rented bikes"</b>.</p>
<p>After <b>clicking on the "Submit rent"</b> the bike must swow up in "Available bikes" list.</p>
<p>User can rent bike from "Available bikes" list. There are two buttons in front of each bike: <b>"Rent"</b> and <b>"Delete"</b>.
After clicking on the "<b>Rent"</b> the bike must disappear from "Available bikes" and show up in "Rented bikes".
To end the rent User must click <b>"Cancel rent"</b> in front of the bike of "Rented bikes" and the bike must be returned to the "Available bikes".</p>
<p>Before each list must show up <b>count of elements inside</b>.</p>
<p>Whole information must be stored on the server in the database and automatically be loaded when the page is reloaded.</p>
<p><b>Server</b> side must have <b>CRUD</b> operations.</p>
<p><b>Database</b> must have table with bikes. Bike must have all of required fields:</p>
<ul><b>
  <li>Title</li>
  <li>Type (Road / Mountain)</li>
  <li>Rent price ($)</li>
  <li>Status of the rent (Free / Rented)</li>
</b></ul>
<h2>Technologies used</h2>
<b>
	<ul>
	  <li>Frontend</li>
		<ul>
		  <li>TS (Angular)</li>
		  <li>HTML5 + CSS3</li>
		  <li>Bootstrap</li>
		</ul>
	  <li>Backend</li>
		<ul>
		  <li>C#</li>
		  <li>.NET Сore WebAPI</li>
		  <li>EF Core</li>
		</ul>
	  <li>Database side</li>
		<ul>
		  <li>MsSQL Server</li>
		</ul>
	</ul>
</b>
