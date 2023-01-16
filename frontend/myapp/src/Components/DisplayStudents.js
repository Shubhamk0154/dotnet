import {useEffect,useState} from "react";
import axios from 'axios';

 const  DisplayStudents =(props) => {
     const [studarr,setstudarr] = useState([]);
     useEffect(
         () => {
             axios.get('http://localhost:5196/api/student')
             .then(respone =>{setstudarr(respone.data)})
         }
     )
//-----
     var tablerows = studarr.map(obj =>{
         return(
             <tr>
             <td>{obj.id}</td>
             <td>{obj.name}</td>
             <td>{obj.course}</td>
             </tr>
         );
     });
//-----
     return (
         <>
         <br></br>
         <table id="studentTable" border="2px" bgcolor="cyan" >
         <tr>
         <td> Student Id </td>
         <td> Name </td>
         <td> Course</td>
         </tr>
         {tablerows}
         </table>
         </>
         );

 }

export default DisplayStudents;