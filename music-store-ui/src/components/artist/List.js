import React, { Component } from 'react';

import { ArtistListPaginatedRequest, ArtistListPaginatedResponse } from "../../Client/Artist/artist_pb";
import { ArtistServiceClient } from '../../Client/Artist/artist_grpc_web_pb';

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

                    </tr>
                </thead>
                <tbody>
                    {artists.map(artist =>
                        <tr key={artist.name}>
                            <td>{artist.name}</td>
                            <td>{artist.dateOfBirth}</td>

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

                {contents}
            </div>
        );
    }

    async populateData() {

        var artistRequest = new ArtistListPaginatedRequest();
        artistRequest.setPagesize(100);
        var stream = client.artistListPaginate(artistRequest, {}, (err, response) => {        
            
            console.log(response.toObject());
            this.setState({ artists: response.toObject().itemsList, loading: false });
        });

       


    }
}