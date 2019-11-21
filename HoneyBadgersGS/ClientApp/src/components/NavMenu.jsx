import React, { Component } from 'react';
import { Collapse, Container, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import { LoginMenu } from './api-authorization/LoginMenu';
import Logo from '../images/HBGS Logo.png';
import './NavMenu.css';

export class NavMenu extends Component {
  static displayName = NavMenu.name;

  constructor (props) {
    super(props);

    this.toggleNavbar = this.toggleNavbar.bind(this);
    this.state = {
      collapsed: true
    };
  }

  toggleNavbar () {
    this.setState({
      collapsed: !this.state.collapsed
    });
  }

  render () {
    return (
      <header>
        <Navbar className="navbar-expand-sm navbar-toggleable-sm box-shadow mb-3" light>
          <Container>
                    <NavbarBrand tag={Link} to="/"><img src={Logo} className="honeyBadgerLogo" alt="Honey Badger Logo"></img></NavbarBrand>
                    <form>
                        <input className="storeSearch mr-sm-2" type="text" placeholder="Search"></input>
                    </form>
            <NavbarToggler id="hamburger" onClick={this.toggleNavbar} className="mr-2"  />
            <Collapse className="d-sm-inline-flex flex-sm-row-reverse" isOpen={!this.state.collapsed} navbar >
              <ul className="navbar-nav flex-grow">
                <NavItem>
                  <NavLink tag={Link} className="text-light" to="/">Home</NavLink>
                </NavItem>
                <NavItem>
                    <NavLink tag={Link} className="text-light" to='/Cart'>Cart</NavLink>
                </NavItem>
                <NavItem>
                <NavLink tag={Link} className="text-light" to='/Wishlist'>Wishlist</NavLink>
                </NavItem>
                <NavItem>
                    <NavLink tag={Link} className="text-light" to='/Events'>Events</NavLink> 
                </NavItem>      
                <NavItem>
                    <NavLink tag={Link} className="text-light" to='/FriendList'>Friends</NavLink>
                </NavItem>                  
                <LoginMenu></LoginMenu>
                        </ul>
                        
                </Collapse>
                   
          </Container>
        </Navbar>
      </header>
    );
  }
}
