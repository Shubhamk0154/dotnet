import { useState} from "react";
import axios from 'axios';

const Insertdata = (props) => {
    const [studData,setstudData]= useState({name:"",course:""});

    const savedata =(event) => {
        event.preventDefault();
        axios.post('http://localhost:5196/api/student',studData);
    }

    const handleChange=(event)=>{
        const {name,value} =event.target
        setstudData({...studData,[name]:value})
    }


    return(
        <>
        <br/><br/>
        <h4>Add new Student</h4>
        <form method="POST" onSubmit={savedata}>
            <input type="text" name="name" onChange={handleChange} placeholder="StudentName"/>
            <input type="text" name="course" onChange={handleChange} placeholder="course"/>
            <input type="Submit"/>
        </form>
        </>
    );
}
export default Insertdata;

//--