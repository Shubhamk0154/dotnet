import { useState } from "react";
import axios from 'axios';

const DeleteData = () => {
    const [studData, setstudData] = useState({id:""});

    const deleteStudent = (event) => {
        event.preventDefault();
        axios.delete(`http://localhost:5196/api/student/${studData.id}`);
    }

    const handleChange =(event) => {
        const {name,value}=event.target
        setstudData({...studData,[name]:value})
    }

    return (
        <>
        <br/><br/>
        <h4> Enter id to be deleted</h4>
        <form method="GET" onSubmit={deleteStudent}>
            <input type="text" name="id" onChange={handleChange} placeholder="id"/>
            <input type="Submit" value="Delete"/>
        </form>
        </>
    );
}
export default DeleteData;