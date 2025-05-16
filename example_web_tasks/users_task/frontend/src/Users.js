import { useEffect, useState } from "react";
import axios from "axios";

const Users = () => {
    const [users, setUsers] = useState([])
    const [role, setRole] = useState(null);
    const [activeRole, setActiveRole] = useState(null);
    const [search, setSearch] = useState("");

    useEffect(() => {
        axios.get("http://localhost:8080/users")
            .then((res) => {
                console.log(res.data);
                setUsers(res.data);
            })
    }, [])

    const handleSearch = () => {
        setActiveRole(role)
    }

    const handleDelete = (idToDelete) => {
        // chat solution
        axios.delete(`http://localhost:8080/delete/${idToDelete}`)
            .then(response => {
                if (response.status === 200 || response.status === 204) {
                    //console.log("User deleted successfully", idToDelete);
                    setUsers(newUsers => newUsers.filter(user => user.id !== idToDelete));
                } else {
                    console.error("Failed to delete user on backend:", response);
                }
            })
            .catch(error => {
                console.error("Error deleting user:", error);
                alert("Failed to delete user. " + (error.response?.data?.message || error.message));
            });
        //simpler version
        // axios.delete(`http://localhost:8080/delete/${idToDelete}`)
        //     .then(response => {
        //         setUsers(newUsers => newUsers.filter(user => user.id !== idToDelete));
        //     })
    }

    const uniqueRoles = [...new Set(users.map(user => user.role))];

    return (
        <div className="container">
            <div className="d-flex p-3 align-items-center gap-2">
                {/* <label className="text-center">Wyszukaj po imieniu</label> */}
                <input type="text" className="form-control" placeholder="Username" aria-label="Username" aria-describedby="addon-wrapping" onChange={e => { setSearch(e.target.value) }} />
                <select name="roles" id="roles" className="form-control" onChange={(e) => { setRole(e.target.value) }}>
                    <option disabled selected hidden>Wybierz role do filtrowania</option>
                    {/* <option value="1">1</option> */}
                    {uniqueRoles.map((role, index) => {
                        return (
                            <option value={role} key={index}>{role}</option>
                        )
                    })}
                </select>
                <button type="button" className="btn btn-primary" onClick={handleSearch}>Szukaj</button>
            </div>
            <div>
                <table className="table">
                    <thead>
                        <tr>
                            <th scope="col">#</th>
                            <th scope="col">First</th>
                            <th scope="col">Last</th>
                            <th scope="col">Email</th>
                            <th scope="col">Role</th>
                            <th scope="col">Action</th>
                        </tr>
                    </thead>
                    <tbody>
                        {users.map((user, index) => {

                            if (!(search === "" || user.name.toLowerCase().includes(search.toLowerCase()))) return null;

                            if (!(activeRole === null || activeRole.includes(user.role))) return null;

                            return (
                                <tr key={index}>
                                    <th scope="row">{user.id}</th>
                                    <td>{user.name.split(' ')[0]}</td>
                                    <td>{user.name.split(' ')[1]}</td>
                                    <td>{user.email}</td>
                                    <td>{user.role}</td>
                                    <td><button type="button" className="btn btn-danger" onClick={() => handleDelete(user.id)}>Usuń</button></td>
                                </tr>
                            )
                        })}
                        {/* chat fragment */}
                        {users.filter(user =>
                            (search === "" || (user.name && user.name.toLowerCase().includes(search.toLowerCase()))) &&
                            (activeRole === "" || activeRole === null || user.role === activeRole)
                        ).length === 0 && (
                                <tr>
                                    <td colSpan="6" className="text-center">No users match the criteria.</td>
                                </tr>
                            )}
                    </tbody>
                </table>
            </div>
        </div>
    )
}
export default Users;