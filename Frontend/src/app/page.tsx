import Link from "next/link";
import styles from "./styles/Home.module.css";
import "./globals.css"; // Import the global CSS file

const Home: React.FC = () => {
  return (
    <div>

              <div className={styles.navbar_mobile}>
                
                <div className={`${styles.container} ${styles.nav_container}`}>
                    <input className={styles.checkbox} type="checkbox" name="" id="" />

                    <div className={styles.hamburger_lines}>
                      <span className={`${styles.line} ${styles.line1}`}></span>
                      <span className={`${styles.line} ${styles.line2}`}></span>
                      <span className={`${styles.line} ${styles.line3}`}></span>
                    </div>  
                    <div className={styles.logo}>
                      <h1>Navbar</h1>
                    </div>
                    <div className={styles.menu_items}>
                      <li><Link href="/" className={styles.links_css}>Home</Link></li>
                      <li><Link href="/" className={styles.links_css}>About</Link></li>
                      <li><Link href="/" className={styles.links_css}>Discord</Link></li>
                  </div>
                </div>
                
              </div>
      <nav className={styles.navbar}>
        
        <ul>
          <li>
            <Link href="/">Home</Link>
          </li>
          <li>
            <Link href="/about">About</Link>
          </li>
          <li>
            <Link href="/contact">Discord</Link>
          </li>
        </ul>
     

      </nav>
      <div className={styles.heroImage}>
        <div className={styles.heroText}>
          <h1>Explore Space</h1>
          <p>Exploring the Wonders of Space</p>


          <div className={styles.heroButtons}>
            
            <Link href="/Login" className={styles.heroButton}>
              <strong className={styles.strongclass}>LOGIN</strong> 
              <div id={styles.container_stars}>
                <div id={styles.stars}></div>
              </div>

              <div id={styles.glow}>
                <div className={styles.circle}></div>
                <div className={styles.circle}></div>
              </div>

            </Link>

            <Link href="/Login" className={styles.heroButton}>
              <strong className={styles.strongclass}>REGISTER</strong> 
              <div id={styles.container_stars}>
                <div id={styles.stars}></div>
              </div>

              <div id={styles.glow}>
                <div className={styles.circle}></div>
                <div className={styles.circle}></div>
              </div>

            </Link>

          </div>
        </div>
      </div>
      

      <section>
        <h2>What I do</h2>
        <p>
          I am a programmer, and I have been programming for 3 years. I have
          experience with React, Next.js, Node.js, Express.js, MongoDB, and
          MySQL.
        </p>
        
      </section>
    </div>
  );
};

export default Home;
