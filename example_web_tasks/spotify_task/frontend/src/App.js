import React, { useState } from 'react';
import './App.css';
import 'bootstrap';

function App() {
  const data = [
    { id: 0, alt: "Mak", filename: "obraz1.jpg", category: 1, downloads: 35 },
    { id: 1, alt: "Bukiet", filename: "obraz2.jpg", category: 1, downloads: 43 },
    { id: 2, alt: "Dalmatyńczyk", filename: "obraz3.jpg", category: 2, downloads: 2 },
    { id: 3, alt: "Świnka morska", filename: "obraz4.jpg", category: 2, downloads: 53 },
    { id: 4, alt: "Rotwailer", filename: "obraz5.jpg", category: 2, downloads: 43 },
    { id: 5, alt: "Audi", filename: "obraz6.jpg", category: 3, downloads: 11 },
    { id: 6, alt: "kotki", filename: "obraz7.jpg", category: 2, downloads: 22 },
    { id: 7, alt: "Róża", filename: "obraz8.jpg", category: 1, downloads: 33 },
    { id: 8, alt: "Świnka morska", filename: "obraz9.jpg", category: 2, downloads: 123 },
    { id: 9, alt: "Foksterier", filename: "obraz10.jpg", category: 2, downloads: 22 },
    { id: 10, alt: "Szczeniak", filename: "obraz11.jpg", category: 2, downloads: 12 },
    { id: 11, alt: "Garbus", filename: "obraz12.jpg", category: 3, downloads: 321 }]

  const [kwiaty, setKwiaty] = useState(true)
  const [zwierzeta, setZwierzeta] = useState(true)
  const [samochody, setSamochody] = useState(true)

  const Tile = ({ downloads, filename, alt }) => {
    const [count, setCount] = useState(downloads)

    const handlePobierz = () => {
      setCount(count + 1);
    }
    return (
      <div>
        <img src={`images/${filename}`} alt={alt} />
        <h4>Pobrań: {count}</h4>
        <button type="button" className="btn btn-success" onClick={() => { handlePobierz() }}>Pobierz</button>
      </div>
    )
  }

  const [search, setSearch] = useState("")

  const handleSearch = (val) => {
    console.log(val);
    setSearch(val)
  }

  return (
    <div className="App">
      <h2>Kategorie zdjęć</h2>
      <div className='d-flex gap-2'>
        <input type="text" onChange={(e) => handleSearch(e.target.value)} />
        <div className="form-check form-switch">
          <input className="form-check-input" type="checkbox" role="switch" id="switchCheckDefault" onChange={() => setKwiaty(!kwiaty)} defaultChecked />
          <label className="form-check-label" htmlFor="switchCheckDefault">Kwiaty</label>
        </div>
        <div className="form-check form-switch">
          <input className="form-check-input" type="checkbox" role="switch" id="switchCheckDefault2" onChange={() => setZwierzeta(!zwierzeta)} defaultChecked />
          <label className="form-check-label" htmlFor="switchCheckDefault2">Zwierzęta</label>
        </div>
        <div className="form-check form-switch">
          <input className="form-check-input" type="checkbox" role="switch" id="switchCheckDefault3" onChange={() => setSamochody(!samochody)} defaultChecked />
          <label className="form-check-label" htmlFor="switchCheckDefault3">Samochody</label>
        </div>
      </div>
      <div className='d-flex flex-wrap gap-2'>
        {data.map((obraz, index) => {

          if (!kwiaty && obraz.category === 1) return null
          if (!zwierzeta && obraz.category === 2) return null
          if (!samochody && obraz.category === 3) return null

          if (!obraz.alt.toLowerCase().includes(search.toLowerCase())) return null

          return (
            <Tile key={index} downloads={obraz.downloads} filename={obraz.filename} alt={obraz.alt} />
          )
        })}
      </div>
    </div>
  );
}

export default App;
