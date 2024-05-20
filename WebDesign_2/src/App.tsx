import 'bootstrap/dist/css/bootstrap.min.css';
import { useState } from "react";
import { useEffect } from "react";


function Users()
{
  const [user, setUser] = useState("Default");
 /*useState({
    id: "None",
    Name: "Null",
    Age: "0"
  }); 
  */


  useEffect( () => {
    const response = fetch("https://localhost:7095/api/React")
    .then(res => res.text())
    .then(data => setUser(data))
  });

  return(
    <h2>
      My name is {user} and I am 11 years old.
    </h2>
  )
}



function App() {

  return(
    <>
      <Users/>
    </>
  )
}

export default App
