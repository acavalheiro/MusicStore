import React, { Component } from 'react';
import { Button } from 'reactstrap';
import { ArtistListPaginatedRequest, ArtistListPaginatedResponse , ArtistItem } from "../../Client/Artist/artist_pb";
import { ArtistServiceClient } from '../../Client/Artist/artist_grpc_web_pb';

import { Link } from 'react-router-dom';

var client = new ArtistServiceClient('https://localhost:5001');

export class ListArtist extends Component {


    static displayName = ListArtist.name;

    constructor(props) {
        super(props);
        this.state = { artists: [], loading: true };
    }

    componentDidMount() {
        this.populateData();
    }

    static renderTable(artists) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Date Of Birth</th>
                        <th>Artistic Name</th>

                    </tr>
                </thead>
                <tbody>
                    {artists.map(artist =>
                        <tr key={artist.id}>
                            <td>{artist.name}</td>
                            <td>{artist.dateOfBirth.toString()}</td>
                            <td>{artist.artisticName}</td>

                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : ListArtist.renderTable(this.state.artists);

        return (
            <div>
                <h1 id="tabelLabel" >Artists</h1>
                <Button tag={Link}  className="btn btn-primary" to="/artist-create">Create</Button>
                {contents}
            </div>
        );
    }

    async populateData() {

        var artistRequest = new ArtistListPaginatedRequest();
        artistRequest.setPagesize(100);
        var stream = client.artistListPaginate(artistRequest, {}, (err, response) => {        
            
            //var items = response.getItemsList().map()
           

            var data = response.getItemsList().map( a => ({ id: a.getId(), name: a.getName(), dateOfBirth: a.getDateofbirth().toDate(), artisticName: a.getArtisticname()}));

            // console.log(t);
            // console.log(response.toObject());
            // console.log(response);
            this.setState({ artists: data, loading: false });
        });

       


    }
}