const express = require('express');
const cors = require('cors');
const app = express();

app.use(cors())
app.use(express())

let users = [
    { id: 1, name: "Alice Wonderland", email: "alice@example.com", role: "Admin" },
    { id: 2, name: "Bob Builder", email: "bob@example.com", role: "User" },
    { id: 3, name: "Charlie Brown", email: "charlie@example.com", role: "Editor" },
    { id: 4, name: "Diana Prince", email: "diana@example.com", role: "User" }
];

app.get('/users', (req, res) => {
    res.json(users)
});

app.delete('/delete/:id', (req, res) => {
    const idToDelete = parseInt(req.params.id, 10); // Parse ID from URL param to integer

    if (isNaN(idToDelete)) {
        return res.status(400).json({ message: "Invalid ID format." });
    }

    const initialLength = users.length;
    users = users.filter(user => user.id !== idToDelete); // Strict comparison with parsed ID

    if (users.length < initialLength) {
        console.log("User deleted. New users array:", users);
        res.status(200).json({ message: "User deleted successfully", id: idToDelete }); // Send a success response
        // or res.sendStatus(204); // No content, but success
    } else {
        console.log("User not found with ID:", idToDelete);
        res.status(404).json({ message: "User not found" }); // Send a not found response
    }
});


app.listen(8080, () => {
    console.log(`Serwer nasłuchuje na porcie 8080`);
});
