import React, { Component } from 'react';
import { GameList } from './Game-List/gameList.component';
import './Home.css';

export class Home extends Component {

    constructor() {
        super();
        this.state = {
            games: []
        };
    }

    //talks to the api in order to get the games from the database.
    componentDidMount() {
        fetch("https://localhost:5001/api/games/getGames")
            .then(response => response.json())
            .then(data => this.setState({ games: data }, console.log(data)))
        
    }


    render() {
        return (
            <div className='home-method'>
                <GameList games={this.state.games}></GameList>
            </div>
        )
    }
}
