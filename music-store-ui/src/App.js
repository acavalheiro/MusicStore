import React, { useState, useEffect, Component } from 'react';
import logo from './logo.svg';
import './App.css';


import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import { ListArtist } from "./components/artist/List";
import { CreateArtist } from "./components/artist/Create";


export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/counter' component={Counter} />
        <Route path='/fetch-data' component={FetchData} />
        <Route path='/artist' component={ListArtist} />
        <Route path='/artist-create' component={CreateArtist} />
      </Layout>
    );
  }
}


// var client = new ArtistServiceClient('https://localhost:5001');
// function App() {

//   const [temp, setTemp] = useState(-9999);

//   const getData = () => {
//     console.log('called');

//     var artistRequest = new ArtistListPaginatedRequest();
//     artistRequest.setPagesize(100);
//     var stream = client.artistListPaginate(artistRequest, {}, (err: grpcWeb.Error, response: ArtistListPaginatedResponse) => {
//       console.log(response.getTotalitems());
//       console.log(response.getItemsList());
//     });

//     // stream.on('error', function(error){
//     //   console.error(error);
//     // });

//     // stream.on('data', function (response) {
//     //   var data = response.getData();
//     //   console.log('response');
//     //   console.log(data);
//     // });


//   };

//   useEffect(() => {
//     getData()
//   }, []);

//   return (
//     <div className="App">
//       <header className="App-header">
//         <img src={logo} className="App-logo" alt="logo" />
//         <p>
//           Edit <code>src/App.js</code> and save to reload.
//         </p>
//         <a
//           className="App-link"
//           href="https://reactjs.org"
//           target="_blank"
//           rel="noopener noreferrer"
//         >
//           Learn React
//         </a>
//       </header>
//     </div>
//   );
// }

// export default App;
