# Execute the post request

CURL:

curl -v -H 'Content-Type:application/json'  -k -POST 'https://localhost:5001/Api/ApiHome/CreateUser' -d '{"id":1,"name":"Gio","email":"gio@homail.com","phone":"3131313131","message":"Hola"   }'
