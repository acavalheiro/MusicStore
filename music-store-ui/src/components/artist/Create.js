import React, { Component } from 'react';
import { Form, FormGroup, Label, Input, Row, Col, Button } from 'react-bootstrap';
import Datetime from 'react-datetime';
import "react-datetime/css/react-datetime.css";

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