const express = require('express');
const cors = require('cors');
const app = express();

app.use(cors())
app.use(express())

const users = [
    { id: 1, name: "Alice Wonderland", email: "alice@example.com", role: "Admin" },
    { id: 2, name: "Bob The Builder", email: "bob@example.com", role: "User" },
    { id: 3, name: "Charlie Brown", email: "charlie@example.com", role: "Editor" },
    { id: 4, name: "Diana Prince", email: "diana@example.com", role: "User" }
];

app.get('/api/users', (req, res) => {
    res.json(users)
});



app.listen(8080, () => {
    console.log(`Serwer nasłuchuje na porcie 8080`);
});
