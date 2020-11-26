import React, { Component } from 'react';
import { Form, FormGroup, Label, Input, Row, Col, Button } from 'react-bootstrap';
import Datetime from 'react-datetime';
import "react-datetime/css/react-datetime.css";

import { ArtistServiceClient } from '../../Client/Artist/artist_grpc_web_pb';
import { CreateArtistRequest, CreateArtistResponse, ArtistItem } from '../../Client/Artist/artist_pb';

var pb = require('../../Client/Artist/artist_pb');
var google_protobuf_timestamp_pb = require('google-protobuf/google/protobuf/timestamp_pb.js');


var client = new ArtistServiceClient('https://localhost:5001');

export class CreateArtist extends Component {
    constructor(props) {
        super(props);
        this.state = { 
            name : '',
            dateOfBirth : '',
            artisticName : ''
         };

        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    handleChange(event) {
        const target = event.target;
        const value =  target.value;
        const name = target.name;

        console.log(event);

        this.setState({
            [name]: value
          });

        this.setState({ value: event.target.value });
    }

    handleSubmit(event) {

        const request = new CreateArtistRequest();

        
        var artist = new ArtistItem()
        artist.setName(this.state.name);
        const date = new google_protobuf_timestamp_pb.Timestamp();
        date.fromDate(this.state.dateOfBirth.toDate());        
        artist.setDateofbirth(date);
        artist.setArtisticname(this.state.artisticName);
        request.setArtist(artist);

        var response = client.createArtist(request);

        console.log(response);

        
        alert('A name was submitted: ' + this.state.dateOfBirth);
        event.preventDefault();
    }

    render() {
        return (
            <Form onSubmit={this.handleSubmit}>

                <Form.Row>
                    <Form.Group as={Col} controlId="formGridEmail">
                        <Form.Label>Name</Form.Label>
                        <Form.Control type="text" name="name" value={this.state.name} onChange={this.handleChange} />
                    </Form.Group>

                    <Form.Group as={Col} controlId="formGridPassword">
                        <Form.Label>Date Of Birth</Form.Label>
                        
                        <Datetime value={this.state.dateOfBirth} name="dateOfBirth" onChange={date => this.setState({ dateOfBirth : date})} dateFormat="DD-MM-YYYY" timeFormat={false} />
                    </Form.Group>

                    <Form.Group as={Col} controlId="formGridEmail">
                        <Form.Label>Artistic Name</Form.Label>
                        <Form.Control type="text" name="artisticName" value={this.state.artisticName} onChange={this.handleChange} />
                    </Form.Group>
                </Form.Row>

                <Button type="submit">Submit</Button>                
            </Form>

        );
    }
}