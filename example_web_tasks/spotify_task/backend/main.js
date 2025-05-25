const cors = require('cors');
const express = require('express');

const app = express();

app.use(cors());
app.use(express.json());

app.get('/', (req, res) => {
    res.json({
        key: 'Hello World!',
    });
});

app.listen(8000, () => {
    console.log('Server listening');
});