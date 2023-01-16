import logo from './logo.svg';
import './App.css';
import DisplayStudents from './Components/DisplayStudents';
import InsertStudent from './Components/InsertStudent';
import DeletStudent from './Components/DeleteStudent';
function App() {
  return (
    <div>
      <DisplayStudents></DisplayStudents>
      <InsertStudent></InsertStudent>
      <DeletStudent></DeletStudent>
    </div>
  );
}

export default App;
